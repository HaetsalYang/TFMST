using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BusinessAssociates.Framework;
using BusinessAssociates.Framework.Data;
using BusinessAssociates.Framework.Windows.Forms;
using BusinessAssociates.Framework.Utility;
using BusinessAssociates.Plaza.Security;
using BusinessAssociates.Plaza.Utility;
using BusinessAssociates.Plaza.Windows.Forms;
using BusinessAssociates.Plaza.Windows.Forms.MST;

namespace BusinessAssociates.Plaza.Windows.Forms.MST
{
    public partial class TFMST_SpoM: BusinessAssociates.Plaza.Windows.Forms.BAPlazaMdiChildContainer
    {
        private BADbConnectionInfo conInfo;
        private Schema.ICAT.Table.MST.SpoM infSpoM = new Schema.ICAT.Table.MST.SpoM();
        private BAStandardSQLModule sqlSpoM;

        public TFMST_SpoM()
        {
            InitializeComponent();
            SetBinding();
        }
        private void SetBinding()
        {
            if (!this.DesignMode)
            {
                this.txtSpoCD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSpoM, "SPOCD", true));
                this.txtSpoNM.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSpoM, "SPONM", true));
                this.txtSpoNMAbr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSpoM, "SPONMABR", true));
                this.txtSpoNMSub.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSpoM, "SPONMSUB", true));
                this.txtSpoNMAbrSub.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSpoM, "SPONMABRSUB", true));
                this.txtDspOrd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSpoM, "DSPORD", true));
                this.cboNoUseST.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsSpoM, "NoUseST", true));
            }
        }

        #region Init

        protected override void InitForm(BAPlazaMenuInfo menuInfo)
        {
            base.InitForm(menuInfo);
            InitData();
            PosRec();
            InitStatus();
        }

        private void InitStatus()
        {
            SetLookupStatus(dgrSpoMNOUSEST, "NoUseST", false);
            SetLookupStatus(cboNoUseST, "NoUseST", false);
        }

        private void InitData()
        {
            conInfo = MenuInfo.GetConnectionInfo(infSpoM);
            InitSpoM();
        }

        private void InitSpoM()
        {
            sqlSpoM = GetData().CreateSQLModule(conInfo, infSpoM);
            RegisterDataControl(dctSpoM, infSpoM);
            dctSpoM.SetColumnAllowNull(false, "NoUseST");
            dctSpoM.RegisterColumnValidatingEvent("SpoNM", dctSpoM_SpoNMValidating);
            dctSpoM.RegisterColumnValidatingEvent("SpoNMSub", dctSpoM_SpoNMSubValidating);
            RegisterLogDspButton(cmdLogDspSpoM, dctSpoM);
        }

        #endregion

        #region PosRec

        private void PosRec()
        {
            PosSpoM();
        }

        private void PosSpoM()
        {
            sqlSpoM.SelectSQL.Clear();
            sqlSpoM.SelectSQL.Tables.Add(infSpoM, "T1");
            sqlSpoM.SelectSQL.Fields.AddRange(new string[]
                {
                    "T1.EntCD",
                    "T1.CoCD",
                    "T1.SpoCD",
                    "T1.SpoNM",
                    "T1.SpoNMSub",
                    "T1.SpoNMAbr",
                    "T1.SpoNMAbrSub",
                    "T1.DspOrd",
                    "T1.NoUseST",
                    "T1.CrtUsrID",
                    "T1.CrtDT",
                    "T1.UpdatedBy",
                    "T1.UpdatedOn",
                    "T1.AprUsrID",
                    "T1.AprActDT",
                    "T1.AprST"
                });
            sqlSpoM.SelectSQL.Where.Add(MenuInfo.GetWCndEntCD("T1"));
            sqlSpoM.SelectSQL.Where.Add(MenuInfo.GetWCndCoCD("T1"));
            sqlSpoM.SelectSQL.OrderBy = "T1.EntCD,T1.CoCD,T1.SpoCD, T1.DspOrd";
            dctSpoM.Fill(conInfo, sqlSpoM);
        }

        #endregion

        #region ExecCancel,ExecUpdate, ExecPrint, ExecClose

        protected override void ExecCancel(object sender, EventArgs e)
        {
            base.ExecCancel(sender, e);
            CancelData();
        }

        private void CancelData()
        {
            SaveCurrent();
            dctSpoM.Cancel();
            PosRec();
            RestoreCurrent();
        }

        protected override void ExecUpdate(object sender, EventArgs e)
        {
            base.ExecUpdate(sender, e);
            UpdateData();
        }

        private void UpdateData()
        {
            SaveCurrent();
            dctSpoM.Update(conInfo, sqlSpoM);
            PosRec();
            RestoreCurrent();
        }

   
        protected override void ExecPrint(object sender, EventArgs e)
        {
            base.ExecPrint(sender, e);
            OpenFormByFormClass<Forms.Args.MST.SpoMFormArgs>(
                p => { p.SpoCD = dctSpoM.GetString("SpoCD"); },
                MenuInfo, typeof(TFMST_SpoMRptPmt).Name);
        }

        protected override void ExecClose(object sender, EventArgs e)
        {
            CloseForm();
        }

        #endregion

        #region RowControl

        private void dctSpoM_RowAdded(object sender, EventArgs e)
        {
              dctSpoM.SetValue(
                  new string[] { "EntCD", "CoCD", "NoUseST"},
                  new object[] { MenuInfo.CurEntCD, MenuInfo.CurCoCD, "F" }, BADataControlSetValueOption.NoCheck);
        }

        private void dctSpoM_RowCopied(object sender, BADataRowCopyEventArgs e)
        {
            e.ClearValue(
                new string[] {
                    "SpoCD",
                    "DspOrd",
                    "CrtUsrID",
                    "CrtDT",
                    "UpdatedBy",
                    "UpdatedOn",
                    "AprUsrID",
                    "AprActDT",
                    "AprST"
                });
            dctSpoM.SetValue("NoUseST", "F", BADataControlSetValueOption.NoCheck);
        }

        private void dctSpoM_RowValidating(object sender, BADataRowValidatingEventArgs e)
        {
            dctSpoM.CheckColumnNull(e.Row, new string[] { "SpoCD", "SpoNM", "NoUseST"});
        }

        #endregion


        private void dctSpoM_SpoNMValidating(object sender, BADataColumnValidatingEventArgs e)
        {
            SetNMAbr(dctSpoM, "SpoNM", false);
        }

        private void dctSpoM_SpoNMSubValidating(object sender, BADataColumnValidatingEventArgs e)
        {
            SetNMAbr(dctSpoM, "SpoNM", true);
        }
    }
}
