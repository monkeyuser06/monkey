
Option Explicit On

Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.IO
Imports System.Net.Mail
Imports System.Net
Imports System.Configuration
Imports System.Data.SqlTypes
Imports System.Security.Cryptography
Imports System.Text
Imports Microsoft.Office.Interop
Imports iTextSharp
Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.Data.Odbc

Module newModule

    Public newProdID, ServiceAvailed, AppointmentID, translabel As Integer
    Public Sub ConnectTOSQLServer1()
        Connection = New SqlConnection(sqlConnectionString1)
        Try
            Connection.Open()
        Catch ex As Exception
            MsgBox("Can not open connection ! ")
            End
        End Try
    End Sub

    Public Sub DisConnectSQLServer()
        Try
            Connection.Close()
        Catch ex As Exception
            MsgBox("Can not close connection ! ")
        End Try
    End Sub
    Public Sub Login(Username As String, Password As String)
        Call ConnectTOSQLServer1()
        login_name = ""
        strSQL = "select AccountUsername,AccountID,AccountType,AccountStatus,AccountFullname from tblAccounts where AccountUsername = @Uname and AccountPassword = @Pass"
        Console.WriteLine(strSQL)
        cmd = New SqlCommand(strSQL, Connection)
        cmd.Parameters.AddWithValue("@Pass", SqlDbType.VarChar).Value = GetHash(Password)
        cmd.Parameters.AddWithValue("@Uname", SqlDbType.VarChar).Value = Username
        reader = cmd.ExecuteReader()
        Do While reader.Read()
            login_name = reader.GetString(4)
            login_id = reader.GetInt32(1)
            login_accesstype = reader.GetString(2)
            login_accountstatus = reader.GetString(3)
            login_username = reader.GetString(0)
        Loop
        reader.Close()
        Call DisConnectSQLServer()
    End Sub

    Public Sub PasswordChange(NewPassword As String, SecretQuestionID As Int32, Answer As String)
        Call ConnectTOSQLServer1()
        strSQL = "update tblAccounts set AccountPassword = @Password, SecretQuestionID = @SecretQuestionID, SecretAnswer = @Answer where AccountID = @AccountID"
        cmd = New SqlCommand(strSQL, Connection)
        cmd.Parameters.AddWithValue("@Password", SqlDbType.VarChar).Value = GetHash(NewPassword)
        cmd.Parameters.AddWithValue("@AccountID", SqlDbType.VarChar).Value = login_id
        cmd.Parameters.AddWithValue("@SecretQuestionID", SqlDbType.Int).Value = SecretQuestionID
        cmd.Parameters.AddWithValue("@Answer", SqlDbType.VarChar).Value = Answer
        cmd.ExecuteNonQuery()
        Console.WriteLine(strSQL)
        Call DisConnectSQLServer()
    End Sub
    Public Sub AddItem(Brand As String, Desc As String, Physi As Decimal, Volume As Object, Critical As Decimal, Cont As String, Price As String, Clas As String, expi As Date)
        Call ConnectTOSQLServer1()

        strSQL = "insert into tblInventory(ItemBrand,ItemDescription,PhysicalStock,VolumePerStock,CriticalPoint,ContainerType,Price,ItemClass,Date,TotalVolume)
values(@Brand,@Desc,'" & Physi & "','" & Volume & "','" & Critical & "','" & Cont & "',@Price,'" & Clas & "',getdate(),case when '" & Cont & "'= 'Bottle' then (" & Physi & "*" & Volume & ") else null end);
select SCOPE_IDENTITY()"

        cmd = New SqlCommand(strSQL, Connection)
        cmd.Parameters.AddWithValue("@Brand", SqlDbType.VarChar).Value = Brand
        cmd.Parameters.AddWithValue("@Desc", SqlDbType.VarChar).Value = Desc
        cmd.Parameters.AddWithValue("@Price", SqlDbType.VarChar).Value = Price

        lastIdentity = cmd.ExecuteScalar()
        strSQL = "insert into tblInventoryLogs(ItemID,PhysicalStock,VolumePerStock,TotalVolume,ExpirationDate,Author,AddedDate,ContainerType)
values(@itemID,'" & Physi & "','" & Volume & "',case when '" & Cont & "'= 'Bottle' then (" & Physi & "*" & Volume & ") else null end,'" & expi & "',@Author,getdate(),@cont)"

        cmd = New SqlCommand(strSQL, Connection)
        cmd.Parameters.AddWithValue("@ItemID", SqlDbType.Int).Value = lastIdentity
        cmd.Parameters.AddWithValue("@cont", SqlDbType.VarChar).Value = Cont
        cmd.Parameters.AddWithValue("@Author", SqlDbType.VarChar).Value = login_id
        cmd.ExecuteNonQuery()
        Call DisConnectSQLServer()
    End Sub

    Public Sub AddInventoryLogs(Physi As Decimal, Volume As Object, Expi As Date, cont As String)
        Call ConnectTOSQLServer1()
        strSQL = "insert into tblInventoryLogs(ItemID,PhysicalStock,VolumePerStock,TotalVolume,ExpirationDate,Author,AddedDate,ContainerType)values(@itemID,@Physi,@Volume,case when @Cont = 'Bottle' then (@Physi*@Volume)else null end,@Expidate,@Author,getdate(),@cont)"
        cmd = New SqlCommand(strSQL, Connection)
        cmd.Parameters.AddWithValue("@ItemID", SqlDbType.Int).Value = lastIdentity
        cmd.Parameters.AddWithValue("@Physi", SqlDbType.Decimal).Value = Physi
        cmd.Parameters.AddWithValue("@Volume", SqlDbType.Decimal).Value = Volume
        cmd.Parameters.AddWithValue("@cont", SqlDbType.VarChar).Value = cont
        cmd.Parameters.AddWithValue("@Author", SqlDbType.VarChar).Value = login_id
        cmd.Parameters.AddWithValue("@Expidate", SqlDbType.Date).Value = Expi
        cmd.ExecuteNonQuery()
        Call DisConnectSQLServer()
    End Sub

    Public Sub UpdateItem(Stock As Decimal, ItemID As Int32, volume As Decimal, expi As Date)
        Call ConnectTOSQLServer1()
        strSQL = "update tblInventory set PhysicalStock = PhysicalStock + @Physi, TotalVolume = TotalVolume + ( @Physi *VolumePerStock) 
where ItemID = @itemno; insert into tblInventoryLogs(ItemID,PhysicalStock,VolumePerStock,TotalVolume,ExpirationDate,Author,AddedDate,ContainerType) select ItemID,@physi,VolumePerStock,TotalVolume + (@physi*VolumePerStock),@expidate,@author,getdate(),ContainerType from tblInventory where ItemID = @itemno"

        cmd = New SqlCommand(strSQL, Connection)
        cmd.Parameters.AddWithValue("@Physi", SqlDbType.Decimal).Value = Stock
        cmd.Parameters.AddWithValue("@itemno", SqlDbType.VarChar).Value = ItemID
        cmd.Parameters.AddWithValue("@Volume", SqlDbType.Int).Value = volume
        cmd.Parameters.AddWithValue("@Author", SqlDbType.VarChar).Value = login_id
        cmd.Parameters.AddWithValue("@Expidate", SqlDbType.Date).Value = expi

        Console.WriteLine(strSQL)
        cmd.ExecuteNonQuery()
        Call DisConnectSQLServer()
    End Sub

    Public Sub ManualDeduction(stock As Decimal, itemid As Int32)
        ConnectTOSQLServer1()
        strSQL = "update tblInventory 
set PhysicalStock = PhysicalStock + @Physi, 
TotalVolume = TotalVolume + ( @Physi *VolumePerStock) 
where ItemID = @itemno"
        cmd.Parameters.AddWithValue("@Physi", SqlDbType.Decimal).Value = stock
        cmd.Parameters.AddWithValue("@itemno", SqlDbType.VarChar).Value = itemid
        Console.WriteLine(strSQL)
        cmd.ExecuteNonQuery()
        DisConnectSQLServer()
    End Sub
    Public Sub AddService(ServiceName As String, Price As Decimal, Status As String, Type As String)
        Call ConnectTOSQLServer1()
        strSQL = "insert into tblServices(ServiceName,ServicePrice,ServiceStatus,ServiceType)values(@Name,@Price,@Status,@Type)"
        cmd = New SqlCommand(strSQL, Connection)
        cmd.Parameters.AddWithValue("@Name", SqlDbType.VarChar).Value = ServiceName
        cmd.Parameters.AddWithValue("@Price", SqlDbType.Decimal).Value = Price
        cmd.Parameters.AddWithValue("@Status", SqlDbType.Bit).Value = IIf(Status = "Active", 1, 0)
        cmd.Parameters.AddWithValue("@Type", SqlDbType.VarChar).Value = Type

        cmd.ExecuteNonQuery()
        Console.WriteLine(strSQL)
        Call DisConnectSQLServer()
    End Sub

    Public Sub AddAppointment_V2(datetime As DateTime, custname As String, contact As String, address As String)
        ConnectTOSQLServer1()
        strSQL = "insert into tblTransactions([Date/Time],Author,DataStatus,CustomerName,ContactNumber,Address,TransactionStatus)
values(@datetime,@author,'ACTIVE',@customername,@contactnumber,@address,'For Appointment')"
        cmd = New SqlCommand(strSQL, Connection)
        cmd.Parameters.AddWithValue("@datetime", SqlDbType.VarChar).Value = datetime
        cmd.Parameters.AddWithValue("@author", SqlDbType.VarChar).Value = login_id
        cmd.Parameters.AddWithValue("@customername", SqlDbType.VarChar).Value = custname
        cmd.Parameters.AddWithValue("@contactnumber", SqlDbType.VarChar).Value = contact
        cmd.Parameters.AddWithValue("@address", SqlDbType.VarChar).Value = address
        cmd.ExecuteNonQuery()
        DisConnectSQLServer()
    End Sub

    Public Sub UpdateService(ServiceName As String, Price As Decimal, Status As String, Type As String)
        Call ConnectTOSQLServer1()
        strSQL = "update tblServices Set ServiceName = @ServiceName, ServicePrice =@Price,ServiceStatus = @Status , ServiceType = @Type  where ServiceID = " & lastTransID
        cmd = New SqlCommand(strSQL, Connection)
        cmd.Parameters.AddWithValue("@ServiceName", SqlDbType.VarChar).Value = ServiceName
        cmd.Parameters.AddWithValue("@Price", SqlDbType.Decimal).Value = Price
        cmd.Parameters.AddWithValue("@Status", SqlDbType.Bit).Value = IIf(Status = "Active", 1, 0)
        cmd.Parameters.AddWithValue("@Type", SqlDbType.VarChar).Value = Type
        cmd.ExecuteNonQuery()
        Console.WriteLine(strSQL)
        Call DisConnectSQLServer()
    End Sub



    Public Sub AddServiceAvailed(Lasttrans As Int32, serv As Int32, emp As Int32)
        Call ConnectTOSQLServer1()
        strSQL = "insert into tblServicesAvailed(TransactionID,ServiceID,EmployeeAssigned,DataStatus)values(@Trans,@ServiceID,@Emp,'ACTIVE'); select SCOPE_IDENTITY()"
        cmd = New SqlCommand(strSQL, Connection)
        cmd.Parameters.AddWithValue("@Trans", SqlDbType.Int).Value = Lasttrans
        cmd.Parameters.AddWithValue("@ServiceID", SqlDbType.Int).Value = serv
        cmd.Parameters.AddWithValue("@Emp", SqlDbType.Int).Value = emp
        ServiceAvailed = cmd.ExecuteScalar()

        strSQL = "select * from (
select itemid,ItemNo, 
case 
when PhysicalStock = 0 then 'Item had ran out of stock.' 
 when PhysicalStock < CriticalPoint then 'Item had reached critical level.'
else 'Normal' end
 as ItemStatus
 from tblInventory where ItemID in (
select ItemID from tblServiceConsumables where ServiceID = " & serv & ")) a
where ItemStatus = 'Item had reached critical level.'"
        cmd = New SqlCommand(strSQL, Connection)
        reader = cmd.ExecuteReader()
        If reader.Read = True Then
            reader.Close()
            MsgBox("An item had reached it's critical point. Please check the notifications and restock soon!", MsgBoxStyle.Exclamation, Application.ProductName)
            strSQL = "insert into tblNotifications
select
getdate() as Date,ItemID,ItemStatus
 from (
select * from (
select itemid,ItemNo, 
case 
when PhysicalStock = 0 then 'Item had ran out of stock.' 
 when PhysicalStock < CriticalPoint then 'Item had reached critical level.'
else 'Normal' end
 as ItemStatus
 from tblInventory where ItemID in (
select ItemID from tblServiceConsumables where ServiceID = " & serv & ")) a
where ItemStatus = 'Item had reached critical level.') b"
            cmd = New SqlCommand(strSQL, Connection)
            cmd.ExecuteNonQuery()
        Else
            reader.Close()
        End If


        strSQL = "select * from (
select itemid,ItemNo, 
case 
when PhysicalStock = 0 then 'Item had ran out of stock.' 
 when PhysicalStock < CriticalPoint then 'Item had reached critical level.'
else 'Normal' end
 as ItemStatus
 from tblInventory where ItemID in (
select ItemID from tblServiceConsumables where ServiceID = " & serv & ")) a
where ItemStatus = 'Item had ran out of stock.'"
        cmd = New SqlCommand(strSQL, Connection)
        reader = cmd.ExecuteReader
        If reader.Read = True Then
            reader.Close()

            MsgBox("An item had become out of stock. Please check the notifications and restock soon!", MsgBoxStyle.Exclamation, Application.ProductName)
            strSQL = "insert into tblNotifications
select
getdate() as Date,ItemID,ItemStatus
 from (
select * from (
select itemid,ItemNo, 
case 
when PhysicalStock = 0 then 'Item had ran out of stock.' 
 when PhysicalStock < CriticalPoint then 'Item had reached critical level.'
else 'Normal' end
 as ItemStatus
 from tblInventory where ItemID in (
select ItemID from tblServiceConsumables where ServiceID = " & serv & ")) a
where ItemStatus = 'Item had ran out of stock.') b"
            cmd = New SqlCommand(strSQL, Connection)
            cmd.ExecuteNonQuery()
        Else
            reader.Close()
        End If

        Call DisConnectSQLServer()
        'InventoryProcessing()
    End Sub

    Public Sub AddTransaction(custname As String, add As String, Trans As String)
        Call ConnectTOSQLServer1()
        strSQL = "insert into tblTransactions(CustomerName,Address,[Date/Time],Author,TransactionStatus,DataStatus)values(@Cust,@Add,GETDATE(),@Auth,@trans,'ACTIVE'); select SCOPE_IDENTITY()"
        cmd = New SqlCommand(strSQL, Connection)
        cmd.Parameters.AddWithValue("@Cust", SqlDbType.VarChar).Value = custname
        cmd.Parameters.AddWithValue("@Add", SqlDbType.VarChar).Value = add
        cmd.Parameters.AddWithValue("@Auth", SqlDbType.VarChar).Value = login_id
        cmd.Parameters.AddWithValue("@Trans", SqlDbType.VarChar).Value = Trans

        lastTransID = cmd.ExecuteScalar()
        InventoryProcessing()
        Call DisConnectSQLServer()
    End Sub

    Public Sub InventoryProcessing()
        Call ConnectTOSQLServer1()
        strSQL = "
update tblInventory set PhysicalStock = 
case 
	when ContainerType = 'Sachet' then PhysicalStock - abs(ConsumedNumber)
	else PhysicalStock 
	end,
	TotalVolume = case 
	when ContainerType = 'Bottle' then TotalVolume - abs(ConsumedNumber)
		else TotalVolume
	end 
	from tblInventory a inner join 
	(
	select ItemID,ConsumedNumber from vw_ServiceConsumables where ServiceID in (
	select ServiceID from vw_ServiceAvailed where TransactionID =@lasttrans and ServiceAvailedID = @serviceavailed)) b on a.ItemID = b.ItemID
	where a.ItemID in (b.ItemID);
update tblInventory
set PhysicalStock = ceiling(TotalVolume/VolumePerStock)
where ContainerType = 'Bottle'"
        cmd = New SqlCommand(strSQL, Connection)
        cmd.Parameters.AddWithValue("@lasttrans", SqlDbType.Decimal).Value = lastTransID
        cmd.Parameters.AddWithValue("@serviceavailed", SqlDbType.Decimal).Value = ServiceAvailed

        cmd.ExecuteNonQuery()



        Call DisConnectSQLServer()
    End Sub

    Public Sub RemoveService(serviceavailed As Integer)
        Call ConnectTOSQLServer1()
        strSQL = "
update tblInventory set PhysicalStock = 
case 
	when ContainerType = 'Sachet' then PhysicalStock + abs(ConsumedNumber)
	else PhysicalStock 
	end,
	TotalVolume = case 
	when ContainerType = 'Bottle' then TotalVolume + abs(ConsumedNumber)
		else TotalVolume
	end 
	from tblInventory a inner join 
	(
	select ItemID,ConsumedNumber from vw_ServiceConsumables where ServiceID in (
	select ServiceID from vw_ServiceAvailed where ServiceAvailedID = @serviceavailed)) b on a.ItemID = b.ItemID
	where a.ItemID in (b.ItemID);
update tblServicesAvailed
SET DataStatus = 'DELETED' where ServiceAvailedID = @serviceavailed
"
        cmd = New SqlCommand(strSQL, Connection)
        cmd.Parameters.AddWithValue("@serviceavailed", SqlDbType.Int).Value = serviceavailed

        cmd.ExecuteNonQuery()
        Call DisConnectSQLServer()
    End Sub

    Public Sub AddAppointment(custname As String, contact As String, address As String, appointmentdate As DateTime)
        Call ConnectTOSQLServer1()
        strSQL = "insert into tblAppointment(CustomerName,ContactNumber,Address,AppointmentDate,Author,Date,AppointmentStatus)values(@cust,@contact,@address,@appointment,@auth,getdate(),'Pending'); SELECT CAST(scope_identity() AS int)"
        cmd = New SqlCommand(strSQL, Connection)
        cmd.Parameters.AddWithValue("@cust", SqlDbType.VarChar).Value = custname
        cmd.Parameters.AddWithValue("@contact", SqlDbType.VarChar).Value = contact
        cmd.Parameters.AddWithValue("@address", SqlDbType.VarChar).Value = address
        cmd.Parameters.AddWithValue("@appointment", SqlDbType.DateTime).Value = appointmentdate
        cmd.Parameters.AddWithValue("@auth", SqlDbType.Int).Value = login_id
        cmd.ExecuteScalar()
        newProdID = CType(cmd.ExecuteScalar(), Int32)

        Call DisConnectSQLServer()
    End Sub

    Public Sub UpdateInventoryViaTransaction()
        Call ConnectTOSQLServer1()
        strSQL = ""

        Call DisConnectSQLServer()
    End Sub

    Public Sub AcceptAppointment(appid As Integer)
        Call ConnectTOSQLServer1()
        strSQL = "update tblAppointment set AppointmentStatus = 'Done' where AppointmentID = @appid"
        cmd = New SqlCommand(strSQL, Connection)
        cmd.Parameters.AddWithValue("@appid", SqlDbType.VarChar).Value = appid
        cmd.ExecuteNonQuery()
        Call DisConnectSQLServer()
    End Sub

    Public Sub CompleteTransaction(id As Integer)
        Call ConnectTOSQLServer1()
        strSQL = "
update a
set TransactionStatus = 'Done', Price = b.Price
from tblTransactions a inner join (
select TransactionID,SUM(ServicePrice) as Price from vw_ServiceAvailed group by TransactionID
) b on a.[JA-Transaction] = b.TransactionID
where TransactionID = " & id
        cmd = New SqlCommand(strSQL, Connection)
        cmd.ExecuteNonQuery()
        Call DisConnectSQLServer()
    End Sub


    Public Sub Notification(serviceid_1 As Int32)
        ConnectTOSQLServer1()
        strSQL = "select * from (
select itemid,ItemNo, 
case 
when PhysicalStock = 0 then 'Item had ran out of stock.' 
 when PhysicalStock < CriticalPoint then 'Item had reached critical level.'
else 'Normal' end
 as ItemStatus
 from tblInventory where ItemID in (
select ItemID from tblServiceConsumables where ServiceID = " & serviceid_1 & ")) a
where ItemStatus = 'Item had reached critical level.'"
        cmd = New SqlCommand(strSQL, Connection)
        reader = cmd.ExecuteReader
        If reader.Read Then
            reader.Close()

            MsgBox("An item had reached it's critical point. Please check the notifications and restock soon!", MsgBoxStyle.Exclamation, Application.ProductName)
            strSQL = "insert into tblNotifications
select
getdate() as Date,ItemID,ItemStatus
 from (
select * from (
select itemid,ItemNo, 
case 
when PhysicalStock = 0 then 'Item had ran out of stock.' 
 when PhysicalStock < CriticalPoint then 'Item had reached critical level.'
else 'Normal' end
 as ItemStatus
 from tblInventory where ItemID in (
select ItemID from tblServiceConsumables where ServiceID = " & serviceid_1 & ")) a
where ItemStatus = 'Item had reached critical level.') b"
            cmd = New SqlCommand(strSQL, Connection)
            cmd.ExecuteNonQuery()
        End If

        strSQL = "select * from (
select itemid,ItemNo, 
case 
when PhysicalStock = 0 then 'Item had ran out of stock.' 
 when PhysicalStock < CriticalPoint then 'Item had reached critical level.'
else 'Normal' end
 as ItemStatus
 from tblInventory where ItemID in (
select ItemID from tblServiceConsumables where ServiceID = " & serviceid_1 & ")) a
where ItemStatus = 'Item had ran out of stock.'"
        cmd = New SqlCommand(strSQL, Connection)
        reader = cmd.ExecuteReader()
        If reader.Read Then
            reader.Close()
            MsgBox("An item had become out of stock. Please check the notifications and restock soon!", MsgBoxStyle.Exclamation, Application.ProductName)
            strSQL = "insert into tblNotifications
select
getdate() as Date,ItemID,ItemStatus
 from (
select * from (
select itemid,ItemNo, 
case 
when PhysicalStock = 0 then 'Item had ran out of stock.' 
 when PhysicalStock < CriticalPoint then 'Item had reached critical level.'
else 'Normal' end
 as ItemStatus
 from tblInventory where ItemID in (
select ItemID from tblServiceConsumables where ServiceID = " & serviceid_1 & ")) a
where ItemStatus = 'Item had ran out of stock.') b"
            cmd = New SqlCommand(strSQL, Connection)
            cmd.ExecuteNonQuery()
        End If
        DisConnectSQLServer()
    End Sub
End Module
