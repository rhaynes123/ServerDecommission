using System;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.SqlServer.Management.Common;
using System.Diagnostics;
using System.IO;

//using LCE.StoreSystems.Common;
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
o	Check to see if 10.0.0.11 is available
o	Change to an open 11 to 115
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
        
        public Form1()
        {
            InitializeComponent();
        }

        private void make_server_backup_Click(object sender, EventArgs e)
        {
           
            try
            {
                string connectionString = "Server=127.0.0.1;Database=pizza;Connection Timeout=120;Trusted_Connection=Yes;";
               
                SqlConnection dbconnection = new SqlConnection(connectionString);

                SqlCommand sqlcmd = new SqlCommand();

                SqlDataReader reader;

                sqlcmd.CommandText = "Backup database pizza to disk = 'C:\\srv\\backup\\ServerMove.bak'with format; go";//TODO insert TSQL backup query

                sqlcmd.CommandType = System.Data.CommandType.Text;

                sqlcmd.Connection = dbconnection;

                dbconnection.Open();

                reader = sqlcmd.ExecuteReader();

                dbconnection.Close();

                //TODO db name for file and path needs to be added as well as backup completion
                //c:\BDBackup\BDbackup.cmd
                /*
                 try
                 {
                    Process.Start("BDBackup.cmd");
                 }

                catch(Exception ex)
                {
                    MessageBox.Show("Error: Failure Running the Back Up ", ex.Message)
                }
                 */
                //TODO back failed 1/18/2018 

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {  
            try
            {
                var services = "services.msc";
                Process.Start(services);
            }
            catch(Exception ex)
            {
                MessageBox.Show("No windows Services Found.\n {0}",ex.Message);
            }
            
        }

        private void final_restart_server_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("shutdown", " / r / t 0");
            }
           catch(Exception ex)
            {
                MessageBox.Show("Currently Unable to Shutdown and Restart.\n {0}", ex.Message);
            }
        }

        //Checks for the STANDARD IP Address Scheme and Default Gateway
        private void ScanForServerIPClick(object sender, EventArgs e)
        {
            try
            {

                var message = string.Empty;
                var error = false;

                //Runs a Check to Confirm if the standard server address can be used.
                Ping scanforping = new Ping();

                PingReply ipaddressreply = scanforping.Send("10.0.0.11");
                //Double checks to make sure if the default gateway is also standard.
                Ping defaultGatewayPing = new Ping();

                PingReply Gatewayreply = defaultGatewayPing.Send("10.0.0.1");
                // string.Compare(Gatewayreply.Status, "Success", true);

                if (Gatewayreply.Status == IPStatus.Success)
                {
                    message = "10.0.0.11 is in use. Please Exit";
                }
                else if (Gatewayreply.Status == IPStatus.DestinationHostUnreachable
                    || Gatewayreply.Status == IPStatus.BadDestination)
                {
                    error = true;
                    message = "ERROR: SITE IS ON NON-STANDARD SCHEME: SERVER IP ADDRESS CAN'T BE USED.";

                }
                else
                {
                    error = true;
                    message = string.Format("Standard IP not Found: Reason Status {0}", Gatewayreply.Status);
                }

                MessageBox.Show(message, error ? "Error" : "Information", MessageBoxButtons.OK, error ? MessageBoxIcon.Error : MessageBoxIcon.Information);

                if (error)
                {
                    return;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void stopScheduledTasks_Click(object sender, EventArgs e)
        {
            //TODO Stops the Windows Task
            try
            {
                var taskScheduler = "taskschd.msc";
                Process.Start(taskScheduler);
            }
            catch(Exception ex)
            {
               MessageBox.Show("Unable to open the Task Scheduler.\n {0}", ex.Message);
            }
            
        }

        public void nameEntered_TextChanged(object sender, EventArgs e)
        {
            //Entered Name
            var enteredName = nameEntered.Text.Trim();
        }
            
        public void incidentNumberEntered_TextChanged(object sender, EventArgs e)
        {   
            //Entered Incident
            var incidentNumber = incidentNumberEntered.Text.Trim();
        }
        public void logConfigFilePath()
        {
            //Writes the Log file and reads from the config file.

            var logMessage = "decommisioned this server on date. Please reference incident number: ";
            var logFilename = "decommissionlog.txt";

            DirectoryInfo[] folderPath = new DirectoryInfo(@"c:\srv\backups").GetDirectories();
            //Write to log file
            try
            {
                using (StreamWriter writeLog = new StreamWriter(logFilename))
                {
                    writeLog.WriteLine("{0},{1},{2}", nameEntered, logMessage, incidentNumberEntered);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Unable to Update Folder Path {0}", ex.Message);
                
            }
            finally
            {
               //TODO Close StreamWrite
            }
           
        }

        private void renamebutton_Click(object sender, EventArgs e)
        {
            try
            {
                var rename = "SystemPropertiesComputerName.exe";
                Process.Start(rename);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to access the Hostname settings.\n {0}", ex.Message);
            }
        }
    }
}
