using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
/*
Functions
•	Enter data before start
o	Enter in the name of the tech doing the move
o	Enter the ticket number
o	Log
•	Note
o	Allow the tech an area for notes
•	Make SQL backup of Pizza database
o	Path: C:\srv\backup
o	Filename: ServerMoveMMDDYY.bak
o	Open Explorer
o	Log 
•	Change computer name
o	ServerName to ServerName-Old (what ever the server name is, just add -Old)
o	Log
•	Change IP Address
o	Check to see if 10.0.0.111 is available
o	Change to an open 111 to 115
o	Log
•	Windows Services
o	Stop all the services 
o	Disable all the services
o	C# Config file holds the list
o	List
	Apache 2.2 
	CRSWebCron 
	LCE Store Digital Order Priority Dispatcher
	LCE Store Systems Digital Order Feed Service
	LCE Store Systems Digital Order HNR Portal Service
	SQL Server Express Database (Service Name: SQL Server (DATABASENAME)
	Rabbit MQ
o	Log
•	Windows Scheduled Task
o	Disable all the task
o	C# Config file holds the list
o	List
	ESB CreateRabbitMQConfig
	ESB HeartBeat
	ESB StoreSalesSummary
	BD Backup (optional)
o	Log
•	Log
o	Tech name
o	Ticket number
o	Computer name
o	IP Address
o	Date Time Stamp
o	Log each of the functions begin done with a:
	Start of procedure
	End of procedure with complete or not
o	Email the log (supervisor)
	C# Config file holds the email(s)
	Note attached
o	Copy and paste button
	Note attached
o	On closing of program
	Note attached
	Save log to c:\srv\backup
	Filename: ServerMoveMMDDYY_HHMMSS.txt
•	Reboot Server
o	Dont allow the reboot from the program until the log is emailed

*/
namespace ServerDecommission
{
    public partial class Form1 : Form
    {   
        //SqlConnection con = new SqlConnection()
        public Form1()
        {
            InitializeComponent();
        }

        private void make_server_backup_Click(object sender, EventArgs e)
        {
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            try
            {
                Server dbServer = new Server();
                Backup pizzaBackup = new Backup() { Action = BackupActionType.Database };
                //TODO db name for file and path needs to be added as well as backup completion 
                pizzaBackup.Devices.AddDevice(@"C:\srv\backup\BackupForServerMove.bak",DeviceType.File);
                pizzaBackup.Initialize = true;
                pizzaBackup.PercentComplete += pizzaBackup_PercentComplete;
                pizzaBackup.Complete += pizzaBackup_Complete;
                pizzaBackup.SqlBackupAsync(dbServer);



            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void pizzaBackup_PercentComplete(object snder, ServerMessageEventArgs e)
        {   
            //TODO Exception needs a mean by which to determine if there is a failure
            if(e.Error != null)
            {
                
            }

        }
        private void pizzaBackup_Complete(object snder, ServerMessageEventArgs e)
        {

        }
    }
}
