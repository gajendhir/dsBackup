using System;
using System.IO;
using System.Windows.Forms;
using dsBackup;
using Microsoft.VisualBasic; // Install-Package Microsoft.VisualBasic
using Microsoft.VisualBasic.Logging;

public partial class clsLog
{
    private string AppName;
    private string CreatedOn;
    private string LogFile;
    private string mvarFormName;
    private string mvarDocNo;
    private string mvarWork;
    private string mvarCtrlId;
    private string mvarTrnName;
    private string mvarTrnId;
    private string mvarRemark;
    private string mvarAmount;
    private string mvarCreatedBy;          // Let propety
    private string mvarUserName;          // Get/Let Property

    internal void Add(string vbMessage, string vbUserName = "")
    {
        TextWriter Ffl;
        Ffl = TextWriter.Synchronized(File.AppendText(LogFile));
        Ffl.WriteLine(Strings.Format(DateTime.Now, "yyyy-MMM-dd HH:mm:ss") + ", " + AppName + ", " + vbUserName + ", " + mvarCreatedBy + CreatedOn + ", " + vbMessage);
        Ffl.Close();
    }

    internal void Append()
    {
        TextWriter tw;
        tw = TextWriter.Synchronized(File.AppendText(LogFile));
        tw.WriteLine(Strings.Format(DateTime.Now, "yyyy-MMM-dd HH:mm:ss") + ", " + AppName + ", " + mvarUserName + ", " + mvarCreatedBy + CreatedOn + ", " + mvarFormName + ", " + mvarWork + ", " + mvarCtrlId + ", " + mvarDocNo + ", " + mvarTrnId + ", " + mvarTrnName + ", " + mvarRemark + ", " + mvarAmount);
        tw.Close();
    }

    #region Properties

    internal string UserName
    {
        set
        {
            mvarUserName = value;
        }
    }

    internal string FormName
    {
        set
        {
            mvarFormName = value;
        }
    }

    internal string DocNo
    {
        set
        {
            mvarDocNo = value;
        }
    }

    internal string Work
    {
        set
        {
            mvarWork = value;
        }
    }

    internal string CtrlId
    {
        set
        {
            mvarCtrlId = value;
        }
    }

    internal string Remark
    {
        set
        {
            mvarRemark = value;
        }
    }

    internal string Amount
    {
        set
        {
            mvarAmount = value;
        }
    }

    internal string TrnId
    {
        set
        {
            mvarTrnId = value;
        }
    }

    internal string TrnName
    {
        set
        {
            mvarTrnName = value;
        }
    }

    internal string CreatedBy
    {
        set
        {
            mvarCreatedBy = value;
        }
    }

    #endregion

    public clsLog()
    {
        AppName = typeof(Program).Assembly.GetName().Name + " (" + typeof(Program).Assembly.GetName().Version + ")";
        CreatedOn = System.Environment.MachineName;      // Format(Time(), "HHmmss")
        string path = Application.CommonAppDataPath + "\\dsLOG";
        
        if (!System.IO.Directory.Exists(path))
        {
            FileSystem.MkDir(path);
        }
        LogFile = path + "\\Log-" + DateTime.Today.ToString("yy-MMM") + ".log";
        mvarFormName = "";
        mvarDocNo = "";
        mvarWork = "";
        mvarCtrlId = "";
        mvarRemark = "";
        mvarAmount = "";
        mvarTrnId = "";
        mvarTrnName = "";
        mvarCreatedBy = "";
        mvarUserName = "";
        Add("Application Started");
    }

    ~clsLog()
    {
        Add("Application Ended");
    }

    public void LogEntry(string FormName, string Work, string Remark = "", decimal Amount = 0)
    {
        mvarFormName = FormName;
        mvarWork = Work;
        mvarRemark = Remark;
        mvarAmount =(Amount!=0 ? Amount.ToString() : "");
        Append();
    }
}