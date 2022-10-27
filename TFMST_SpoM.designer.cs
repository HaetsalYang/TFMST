namespace BusinessAssociates.Plaza.Windows.Forms.MST
{
    partial class TFMST_SpoM
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TFMST_SpoM));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            BusinessAssociates.Framework.Windows.Forms.BAColumnSetting baColumnSetting2 = new BusinessAssociates.Framework.Windows.Forms.BAColumnSetting();
            this.bsSpoM = new System.Windows.Forms.BindingSource(this.components);
            this.dsMain = new BusinessAssociates.Plaza.Windows.Forms.MST.TDMST_SpoM();
            this.pnlToolbarUp = new BusinessAssociates.Framework.Windows.Forms.BAToolStrip();
            this.cmdOK = new BusinessAssociates.Framework.Windows.Forms.BAToolStripButton();
            this.cmdCancel = new BusinessAssociates.Framework.Windows.Forms.BAToolStripButton();
            this.cmdPrint = new BusinessAssociates.Framework.Windows.Forms.BAToolStripButton();
            this.cmdClose = new BusinessAssociates.Framework.Windows.Forms.BAToolStripButton();
            this.dgrSpoM = new BusinessAssociates.Framework.Windows.Forms.BADataGridView();
            this.dgrSpoMSPOCD = new BusinessAssociates.Framework.Windows.Forms.BADataGridViewTextBoxColumn();
            this.dgrSpoMSPONM = new BusinessAssociates.Framework.Windows.Forms.BADataGridViewTextBoxColumn();
            this.dgrSpoMSPONMABR = new BusinessAssociates.Framework.Windows.Forms.BADataGridViewTextBoxColumn();
            this.dgrSpoMSPONMSUB = new BusinessAssociates.Framework.Windows.Forms.BADataGridViewTextBoxColumn();
            this.dgrSpoMSPONMABRSUB = new BusinessAssociates.Framework.Windows.Forms.BADataGridViewTextBoxColumn();
            this.dgrSpoMDSPORD = new BusinessAssociates.Framework.Windows.Forms.BADataGridViewTextBoxColumn();
            this.dgrSpoMNOUSEST = new BusinessAssociates.Framework.Windows.Forms.BADataGridViewComboBoxColumn();
            this.lblSpoCD = new BusinessAssociates.Framework.Windows.Forms.BALabel();
            this.lblSpoNM = new BusinessAssociates.Framework.Windows.Forms.BALabel();
            this.lblSpoNMSub = new BusinessAssociates.Framework.Windows.Forms.BALabel();
            this.lblDspOrd = new BusinessAssociates.Framework.Windows.Forms.BALabel();
            this.lblSpoNMAbr = new BusinessAssociates.Framework.Windows.Forms.BALabel();
            this.lblSpoNMAbrSub = new BusinessAssociates.Framework.Windows.Forms.BALabel();
            this.lblNoUseST = new BusinessAssociates.Framework.Windows.Forms.BALabel();
            this.txtSpoCD = new BusinessAssociates.Framework.Windows.Forms.BATextBox();
            this.txtDspOrd = new BusinessAssociates.Framework.Windows.Forms.BATextBox();
            this.txtSpoNM = new BusinessAssociates.Framework.Windows.Forms.BATextBox();
            this.txtSpoNMSub = new BusinessAssociates.Framework.Windows.Forms.BATextBox();
            this.txtSpoNMAbr = new BusinessAssociates.Framework.Windows.Forms.BATextBox();
            this.txtSpoNMAbrSub = new BusinessAssociates.Framework.Windows.Forms.BATextBox();
            this.dctSpoM = new BusinessAssociates.Framework.Windows.Forms.BADataControl(this.components);
            this.pnlToolbarBtm = new BusinessAssociates.Framework.Windows.Forms.BABindingNavigator(this.components);
            this.cmdAddLin = new BusinessAssociates.Framework.Windows.Forms.BAToolStripButton();
            this.cmdCancelLin = new BusinessAssociates.Framework.Windows.Forms.BAToolStripButton();
            this.cmdCopyLin = new BusinessAssociates.Framework.Windows.Forms.BAToolStripButton();
            this.cmdDeleteLin = new BusinessAssociates.Framework.Windows.Forms.BAToolStripButton();
            this.cmdTopLin = new BusinessAssociates.Framework.Windows.Forms.BAToolStripButton();
            this.cmdPrevLin = new BusinessAssociates.Framework.Windows.Forms.BAToolStripButton();
            this.cmdNextLin = new BusinessAssociates.Framework.Windows.Forms.BAToolStripButton();
            this.cmdBotLin = new BusinessAssociates.Framework.Windows.Forms.BAToolStripButton();
            this.cmdLogDspSpoM = new BusinessAssociates.Framework.Windows.Forms.BAToolStripButton();
            this.cboNoUseST = new BusinessAssociates.Framework.Windows.Forms.BALookupComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bsSpoM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlToolbarUp)).BeginInit();
            this.pnlToolbarUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrSpoM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblSpoCD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblSpoNM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblSpoNMSub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDspOrd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblSpoNMAbr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblSpoNMAbrSub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNoUseST)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSpoCD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDspOrd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSpoNM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSpoNMSub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSpoNMAbr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSpoNMAbrSub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlToolbarBtm)).BeginInit();
            this.pnlToolbarBtm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboNoUseST)).BeginInit();
            this.SuspendLayout();
            // 
            // imgMain
            // 
            this.imgMain.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgMain.ImageStream")));
            this.imgMain.Images.SetKeyName(0, "Save.bmp");
            this.imgMain.Images.SetKeyName(1, "BAAddNewItem.bmp");
            this.imgMain.Images.SetKeyName(2, "BACancel.bmp");
            this.imgMain.Images.SetKeyName(3, "BACancelItem.bmp");
            this.imgMain.Images.SetKeyName(4, "BACloseForm.bmp");
            this.imgMain.Images.SetKeyName(5, "BACopyItem.bmp");
            this.imgMain.Images.SetKeyName(6, "BADeleteItem.bmp");
            this.imgMain.Images.SetKeyName(7, "BAExecute.bmp");
            this.imgMain.Images.SetKeyName(8, "BALogDspItem.bmp");
            this.imgMain.Images.SetKeyName(9, "BAOK.bmp");
            this.imgMain.Images.SetKeyName(10, "DefaultImage.bmp");
            this.imgMain.Images.SetKeyName(11, "Find.bmp");
            this.imgMain.Images.SetKeyName(12, "MoveFirst.bmp");
            this.imgMain.Images.SetKeyName(13, "MoveLast.bmp");
            this.imgMain.Images.SetKeyName(14, "MoveNext.bmp");
            this.imgMain.Images.SetKeyName(15, "MovePrevious.bmp");
            this.imgMain.Images.SetKeyName(16, "OpenFolder.bmp");
            this.imgMain.Images.SetKeyName(17, "Print.bmp");
            // 
            // bsSpoM
            // 
            this.bsSpoM.DataMember = "SpoM";
            this.bsSpoM.DataSource = this.dsMain;
            // 
            // dsMain
            // 
            this.dsMain.CaseSensitive = true;
            this.dsMain.DataSetName = "TDMST_SpoM";
            this.dsMain.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnlToolbarUp
            // 
            this.pnlToolbarUp.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.pnlToolbarUp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdOK,
            this.cmdCancel,
            this.cmdPrint,
            this.cmdClose});
            this.pnlToolbarUp.Location = new System.Drawing.Point(0, 0);
            this.pnlToolbarUp.Name = "pnlToolbarUp";
            this.pnlToolbarUp.Size = new System.Drawing.Size(720, 25);
            this.pnlToolbarUp.TabIndex = 0;
            // 
            // cmdOK
            // 
            this.cmdOK.AccelKey = 's';
            this.cmdOK.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdOK.Image = ((System.Drawing.Image)(resources.GetObject("cmdOK.Image")));
            this.cmdOK.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(23, 22);
            this.cmdOK.ToolTipText = "保存(Alt + S)";
            this.cmdOK.Click += new System.EventHandler(this.ExecUpdate);
            // 
            // cmdCancel
            // 
            this.cmdCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdCancel.Image = ((System.Drawing.Image)(resources.GetObject("cmdCancel.Image")));
            this.cmdCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(23, 22);
            this.cmdCancel.ToolTipText = "ｷｬﾝｾﾙ";
            this.cmdCancel.Click += new System.EventHandler(this.ExecCancel);
            // 
            // cmdPrint
            // 
            this.cmdPrint.AccelKey = 'p';
            this.cmdPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdPrint.Image = ((System.Drawing.Image)(resources.GetObject("cmdPrint.Image")));
            this.cmdPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdPrint.Name = "cmdPrint";
            this.cmdPrint.Size = new System.Drawing.Size(23, 22);
            this.cmdPrint.ToolTipText = "ﾌﾟﾘﾝﾄ(Alt + P)";
            this.cmdPrint.Click += new System.EventHandler(this.ExecPrint);
            // 
            // cmdClose
            // 
            this.cmdClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdClose.Image = ((System.Drawing.Image)(resources.GetObject("cmdClose.Image")));
            this.cmdClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(23, 22);
            this.cmdClose.ToolTipText = "終了(Ctrl + F4)";
            this.cmdClose.Click += new System.EventHandler(this.ExecClose);
            // 
            // dgrSpoM
            // 
            this.dgrSpoM.AutoGenerateColumns = false;
            this.dgrSpoM.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrSpoM.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgrSpoM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrSpoM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgrSpoMSPOCD,
            this.dgrSpoMSPONM,
            this.dgrSpoMSPONMABR,
            this.dgrSpoMSPONMSUB,
            this.dgrSpoMSPONMABRSUB,
            this.dgrSpoMDSPORD,
            this.dgrSpoMNOUSEST});
            this.dgrSpoM.DataSource = this.bsSpoM;
            this.dgrSpoM.GridColor = System.Drawing.SystemColors.MenuBar;
            this.dgrSpoM.Location = new System.Drawing.Point(0, 25);
            this.dgrSpoM.Name = "dgrSpoM";
            this.dgrSpoM.RowTemplate.Height = 18;
            this.dgrSpoM.Size = new System.Drawing.Size(720, 240);
            this.dgrSpoM.TabIndex = 8;
            // 
            // dgrSpoMSPOCD
            // 
            this.dgrSpoMSPOCD.DataPropertyName = "SPOCD";
            this.dgrSpoMSPOCD.HeaderText = "ｽﾎﾟｰﾂｺｰﾄﾞ";
            this.dgrSpoMSPOCD.MaxInputLength = 8;
            this.dgrSpoMSPOCD.Name = "dgrSpoMSPOCD";
            this.dgrSpoMSPOCD.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dgrSpoMSPONM
            // 
            this.dgrSpoMSPONM.DataPropertyName = "SPONM";
            this.dgrSpoMSPONM.HeaderText = "ｽﾎﾟｰﾂ名正式";
            this.dgrSpoMSPONM.MaxInputLength = 20;
            this.dgrSpoMSPONM.Name = "dgrSpoMSPONM";
            this.dgrSpoMSPONM.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dgrSpoMSPONMABR
            // 
            this.dgrSpoMSPONMABR.DataPropertyName = "SPONMABR";
            this.dgrSpoMSPONMABR.HeaderText = "ｽﾎﾟｰﾂ名略式";
            this.dgrSpoMSPONMABR.MaxInputLength = 8;
            this.dgrSpoMSPONMABR.Name = "dgrSpoMSPONMABR";
            this.dgrSpoMSPONMABR.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dgrSpoMSPONMSUB
            // 
            this.dgrSpoMSPONMSUB.DataPropertyName = "SPONMSUB";
            this.dgrSpoMSPONMSUB.HeaderText = "ｽﾎﾟｰﾂ名補助";
            this.dgrSpoMSPONMSUB.MaxInputLength = 20;
            this.dgrSpoMSPONMSUB.Name = "dgrSpoMSPONMSUB";
            this.dgrSpoMSPONMSUB.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dgrSpoMSPONMABRSUB
            // 
            this.dgrSpoMSPONMABRSUB.DataPropertyName = "SPONMABRSUB";
            this.dgrSpoMSPONMABRSUB.HeaderText = "ｽﾎﾟｰﾂ名略式補助";
            this.dgrSpoMSPONMABRSUB.MaxInputLength = 8;
            this.dgrSpoMSPONMABRSUB.Name = "dgrSpoMSPONMABRSUB";
            this.dgrSpoMSPONMABRSUB.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dgrSpoMDSPORD
            // 
            this.dgrSpoMDSPORD.DataPropertyName = "DSPORD";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgrSpoMDSPORD.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgrSpoMDSPORD.HeaderText = "並び順";
            this.dgrSpoMDSPORD.MaxInputLength = 8;
            this.dgrSpoMDSPORD.Name = "dgrSpoMDSPORD";
            this.dgrSpoMDSPORD.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrSpoMDSPORD.Width = 70;
            // 
            // dgrSpoMNOUSEST
            // 
            this.dgrSpoMNOUSEST.DataPropertyName = "NOUSEST";
            this.dgrSpoMNOUSEST.HeaderText = "非使用区分";
            this.dgrSpoMNOUSEST.Name = "dgrSpoMNOUSEST";
            this.dgrSpoMNOUSEST.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // lblSpoCD
            // 
            this.lblSpoCD.Location = new System.Drawing.Point(20, 270);
            this.lblSpoCD.Name = "lblSpoCD";
            this.lblSpoCD.Size = new System.Drawing.Size(80, 20);
            this.lblSpoCD.TabIndex = 2;
            this.lblSpoCD.Text = "ｽﾎﾟｰﾂｺｰﾄﾞ";
            this.lblSpoCD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSpoNM
            // 
            this.lblSpoNM.Location = new System.Drawing.Point(20, 295);
            this.lblSpoNM.Name = "lblSpoNM";
            this.lblSpoNM.Size = new System.Drawing.Size(80, 20);
            this.lblSpoNM.TabIndex = 3;
            this.lblSpoNM.Text = "ｽﾎﾟｰﾂ名正式";
            this.lblSpoNM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSpoNMSub
            // 
            this.lblSpoNMSub.Location = new System.Drawing.Point(20, 320);
            this.lblSpoNMSub.Name = "lblSpoNMSub";
            this.lblSpoNMSub.Size = new System.Drawing.Size(80, 20);
            this.lblSpoNMSub.TabIndex = 4;
            this.lblSpoNMSub.Text = "ｽﾎﾟｰﾂ名補助";
            this.lblSpoNMSub.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDspOrd
            // 
            this.lblDspOrd.Location = new System.Drawing.Point(300, 270);
            this.lblDspOrd.Name = "lblDspOrd";
            this.lblDspOrd.Size = new System.Drawing.Size(60, 20);
            this.lblDspOrd.TabIndex = 5;
            this.lblDspOrd.Text = "並び順";
            this.lblDspOrd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSpoNMAbr
            // 
            this.lblSpoNMAbr.Location = new System.Drawing.Point(350, 295);
            this.lblSpoNMAbr.Name = "lblSpoNMAbr";
            this.lblSpoNMAbr.Size = new System.Drawing.Size(100, 20);
            this.lblSpoNMAbr.TabIndex = 6;
            this.lblSpoNMAbr.Text = "ｽﾎﾟｰﾂ名略式";
            this.lblSpoNMAbr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSpoNMAbrSub
            // 
            this.lblSpoNMAbrSub.Location = new System.Drawing.Point(350, 320);
            this.lblSpoNMAbrSub.Name = "lblSpoNMAbrSub";
            this.lblSpoNMAbrSub.Size = new System.Drawing.Size(100, 20);
            this.lblSpoNMAbrSub.TabIndex = 7;
            this.lblSpoNMAbrSub.Text = "ｽﾎﾟｰﾂ名略式補助";
            this.lblSpoNMAbrSub.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNoUseST
            // 
            this.lblNoUseST.Location = new System.Drawing.Point(480, 270);
            this.lblNoUseST.Name = "lblNoUseST";
            this.lblNoUseST.Size = new System.Drawing.Size(80, 20);
            this.lblNoUseST.TabIndex = 8;
            this.lblNoUseST.Text = "非使用区分";
            this.lblNoUseST.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSpoCD
            // 
            this.txtSpoCD.Caption = "";
            this.txtSpoCD.Location = new System.Drawing.Point(120, 270);
            this.txtSpoCD.MaxLength = 10;
            this.txtSpoCD.Name = "txtSpoCD";
            this.txtSpoCD.Size = new System.Drawing.Size(140, 20);
            this.txtSpoCD.TabIndex = 1;
            // 
            // txtDspOrd
            // 
            this.txtDspOrd.Caption = "";
            this.txtDspOrd.Location = new System.Drawing.Point(350, 270);
            this.txtDspOrd.MaxLength = 20;
            this.txtDspOrd.Name = "txtDspOrd";
            this.txtDspOrd.Size = new System.Drawing.Size(80, 20);
            this.txtDspOrd.TabIndex = 6;
            // 
            // txtSpoNM
            // 
            this.txtSpoNM.Caption = "";
            this.txtSpoNM.Location = new System.Drawing.Point(120, 295);
            this.txtSpoNM.MaxLength = 40;
            this.txtSpoNM.Name = "txtSpoNM";
            this.txtSpoNM.Size = new System.Drawing.Size(180, 20);
            this.txtSpoNM.TabIndex = 2;
            // 
            // txtSpoNMSub
            // 
            this.txtSpoNMSub.Caption = "";
            this.txtSpoNMSub.Location = new System.Drawing.Point(120, 320);
            this.txtSpoNMSub.MaxLength = 40;
            this.txtSpoNMSub.Name = "txtSpoNMSub";
            this.txtSpoNMSub.Size = new System.Drawing.Size(180, 20);
            this.txtSpoNMSub.TabIndex = 4;
            // 
            // txtSpoNMAbr
            // 
            this.txtSpoNMAbr.Caption = "";
            this.txtSpoNMAbr.Location = new System.Drawing.Point(480, 295);
            this.txtSpoNMAbr.MaxLength = 16;
            this.txtSpoNMAbr.Name = "txtSpoNMAbr";
            this.txtSpoNMAbr.Size = new System.Drawing.Size(180, 20);
            this.txtSpoNMAbr.TabIndex = 3;
            // 
            // txtSpoNMAbrSub
            // 
            this.txtSpoNMAbrSub.Caption = "";
            this.txtSpoNMAbrSub.Location = new System.Drawing.Point(480, 320);
            this.txtSpoNMAbrSub.MaxLength = 16;
            this.txtSpoNMAbrSub.Name = "txtSpoNMAbrSub";
            this.txtSpoNMAbrSub.Size = new System.Drawing.Size(180, 20);
            this.txtSpoNMAbrSub.TabIndex = 5;
            // 
            // dctSpoM
            // 
            this.dctSpoM.BindingSource = this.bsSpoM;
            baColumnSetting2.ColumnName = null;
            this.dctSpoM.ColumnSettings.Add(baColumnSetting2);
            this.dctSpoM.DataTable = this.dsMain.SpoM;
            this.dctSpoM.EnableFuriganaControl = false;
            this.dctSpoM.IsUpdateExistsChildChanges = true;
            this.dctSpoM.RowValidating += new BusinessAssociates.Framework.Windows.Forms.BADataRowValidatingEventHandler(this.dctSpoM_RowValidating);
            this.dctSpoM.RowAdded += new System.EventHandler(this.dctSpoM_RowAdded);
            this.dctSpoM.RowCopied += new BusinessAssociates.Framework.Windows.Forms.BADataRowCopyEventHandler(this.dctSpoM_RowCopied);
            // 
            // pnlToolbarBtm
            // 
            this.pnlToolbarBtm.AddNewItem = this.cmdAddLin;
            this.pnlToolbarBtm.BindingSource = this.bsSpoM;
            this.pnlToolbarBtm.CancelItem = this.cmdCancelLin;
            this.pnlToolbarBtm.CopyItem = this.cmdCopyLin;
            this.pnlToolbarBtm.CountItem = null;
            this.pnlToolbarBtm.DeleteItem = this.cmdDeleteLin;
            this.pnlToolbarBtm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlToolbarBtm.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.pnlToolbarBtm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdAddLin,
            this.cmdCopyLin,
            this.cmdDeleteLin,
            this.cmdCancelLin,
            this.cmdTopLin,
            this.cmdPrevLin,
            this.cmdNextLin,
            this.cmdBotLin,
            this.cmdLogDspSpoM});
            this.pnlToolbarBtm.Location = new System.Drawing.Point(0, 345);
            this.pnlToolbarBtm.MoveFirstItem = this.cmdTopLin;
            this.pnlToolbarBtm.MoveLastItem = this.cmdBotLin;
            this.pnlToolbarBtm.MoveNextItem = this.cmdNextLin;
            this.pnlToolbarBtm.MovePreviousItem = this.cmdPrevLin;
            this.pnlToolbarBtm.Name = "pnlToolbarBtm";
            this.pnlToolbarBtm.PositionItem = null;
            this.pnlToolbarBtm.Size = new System.Drawing.Size(720, 25);
            this.pnlToolbarBtm.TabIndex = 17;
            // 
            // cmdAddLin
            // 
            this.cmdAddLin.AccelKey = 'I';
            this.cmdAddLin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdAddLin.Image = ((System.Drawing.Image)(resources.GetObject("cmdAddLin.Image")));
            this.cmdAddLin.Name = "cmdAddLin";
            this.cmdAddLin.RightToLeftAutoMirrorImage = true;
            this.cmdAddLin.Size = new System.Drawing.Size(23, 22);
            this.cmdAddLin.ToolTipText = "行追加(Alt + I)";
            // 
            // cmdCancelLin
            // 
            this.cmdCancelLin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdCancelLin.Image = ((System.Drawing.Image)(resources.GetObject("cmdCancelLin.Image")));
            this.cmdCancelLin.Name = "cmdCancelLin";
            this.cmdCancelLin.RightToLeftAutoMirrorImage = true;
            this.cmdCancelLin.Size = new System.Drawing.Size(23, 22);
            this.cmdCancelLin.ToolTipText = "ｷｬﾝｾﾙ";
            // 
            // cmdCopyLin
            // 
            this.cmdCopyLin.AccelKey = 'C';
            this.cmdCopyLin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdCopyLin.Image = ((System.Drawing.Image)(resources.GetObject("cmdCopyLin.Image")));
            this.cmdCopyLin.Name = "cmdCopyLin";
            this.cmdCopyLin.Size = new System.Drawing.Size(23, 22);
            this.cmdCopyLin.Text = "コピー";
            this.cmdCopyLin.ToolTipText = "行ｺﾋﾟｰ(Alt + C)";
            // 
            // cmdDeleteLin
            // 
            this.cmdDeleteLin.AccelKey = 'Y';
            this.cmdDeleteLin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdDeleteLin.Image = ((System.Drawing.Image)(resources.GetObject("cmdDeleteLin.Image")));
            this.cmdDeleteLin.Name = "cmdDeleteLin";
            this.cmdDeleteLin.RightToLeftAutoMirrorImage = true;
            this.cmdDeleteLin.Size = new System.Drawing.Size(23, 22);
            this.cmdDeleteLin.ToolTipText = "行削除(Alt + Y)";
            // 
            // cmdTopLin
            // 
            this.cmdTopLin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdTopLin.Image = ((System.Drawing.Image)(resources.GetObject("cmdTopLin.Image")));
            this.cmdTopLin.Name = "cmdTopLin";
            this.cmdTopLin.RightToLeftAutoMirrorImage = true;
            this.cmdTopLin.Size = new System.Drawing.Size(23, 22);
            this.cmdTopLin.ToolTipText = "先頭ﾍ移動";
            // 
            // cmdPrevLin
            // 
            this.cmdPrevLin.AccelKey = 'P';
            this.cmdPrevLin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdPrevLin.Image = ((System.Drawing.Image)(resources.GetObject("cmdPrevLin.Image")));
            this.cmdPrevLin.Name = "cmdPrevLin";
            this.cmdPrevLin.RightToLeftAutoMirrorImage = true;
            this.cmdPrevLin.Size = new System.Drawing.Size(23, 22);
            // 
            // cmdNextLin
            // 
            this.cmdNextLin.AccelKey = 'N';
            this.cmdNextLin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdNextLin.Image = ((System.Drawing.Image)(resources.GetObject("cmdNextLin.Image")));
            this.cmdNextLin.Name = "cmdNextLin";
            this.cmdNextLin.RightToLeftAutoMirrorImage = true;
            this.cmdNextLin.Size = new System.Drawing.Size(23, 22);
            this.cmdNextLin.ToolTipText = "次行(Alt + N)";
            // 
            // cmdBotLin
            // 
            this.cmdBotLin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdBotLin.Image = ((System.Drawing.Image)(resources.GetObject("cmdBotLin.Image")));
            this.cmdBotLin.Name = "cmdBotLin";
            this.cmdBotLin.RightToLeftAutoMirrorImage = true;
            this.cmdBotLin.Size = new System.Drawing.Size(23, 22);
            this.cmdBotLin.ToolTipText = "末尾ﾍ移動";
            // 
            // cmdLogDspSpoM
            // 
            this.cmdLogDspSpoM.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdLogDspSpoM.Image = ((System.Drawing.Image)(resources.GetObject("cmdLogDspSpoM.Image")));
            this.cmdLogDspSpoM.Name = "cmdLogDspSpoM";
            this.cmdLogDspSpoM.Size = new System.Drawing.Size(23, 22);
            this.cmdLogDspSpoM.ToolTipText = "ﾛｸﾞ情報";
            // 
            // cboNoUseST
            // 
            this.cboNoUseST.Caption = "";
            this.cboNoUseST.Hint = "";
            this.cboNoUseST.Location = new System.Drawing.Point(560, 270);
            this.cboNoUseST.Name = "cboNoUseST";
            this.cboNoUseST.ShowHint = true;
            this.cboNoUseST.Size = new System.Drawing.Size(100, 20);
            this.cboNoUseST.TabIndex = 18;
            // 
            // TFMST_SpoM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Controls.Add(this.cboNoUseST);
            this.Controls.Add(this.pnlToolbarBtm);
            this.Controls.Add(this.txtSpoNMAbrSub);
            this.Controls.Add(this.txtSpoNMAbr);
            this.Controls.Add(this.txtSpoNMSub);
            this.Controls.Add(this.txtSpoNM);
            this.Controls.Add(this.txtDspOrd);
            this.Controls.Add(this.txtSpoCD);
            this.Controls.Add(this.lblNoUseST);
            this.Controls.Add(this.lblSpoNMAbrSub);
            this.Controls.Add(this.lblSpoNMAbr);
            this.Controls.Add(this.lblDspOrd);
            this.Controls.Add(this.lblSpoNMSub);
            this.Controls.Add(this.lblSpoNM);
            this.Controls.Add(this.lblSpoCD);
            this.Controls.Add(this.dgrSpoM);
            this.Controls.Add(this.pnlToolbarUp);
            this.FormText = "ｽﾎﾟｰﾂﾏｽﾀｰ : TFMST_SpoM";
            this.Name = "TFMST_SpoM";
            this.Size = new System.Drawing.Size(720, 370);
            ((System.ComponentModel.ISupportInitialize)(this.bsSpoM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlToolbarUp)).EndInit();
            this.pnlToolbarUp.ResumeLayout(false);
            this.pnlToolbarUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrSpoM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblSpoCD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblSpoNM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblSpoNMSub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDspOrd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblSpoNMAbr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblSpoNMAbrSub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNoUseST)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSpoCD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDspOrd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSpoNM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSpoNMSub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSpoNMAbr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSpoNMAbrSub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlToolbarBtm)).EndInit();
            this.pnlToolbarBtm.ResumeLayout(false);
            this.pnlToolbarBtm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboNoUseST)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Framework.Windows.Forms.BAToolStrip pnlToolbarUp;
        private Framework.Windows.Forms.BADataGridView dgrSpoM;
        private Framework.Windows.Forms.BALabel lblSpoCD;
        private Framework.Windows.Forms.BALabel lblSpoNM;
        private Framework.Windows.Forms.BALabel lblSpoNMSub;
        private Framework.Windows.Forms.BALabel lblDspOrd;
        private Framework.Windows.Forms.BALabel lblSpoNMAbr;
        private Framework.Windows.Forms.BALabel lblSpoNMAbrSub;
        private Framework.Windows.Forms.BALabel lblNoUseST;
        private Framework.Windows.Forms.BATextBox txtSpoCD;
        private Framework.Windows.Forms.BATextBox txtDspOrd;
        private Framework.Windows.Forms.BATextBox txtSpoNM;
        private Framework.Windows.Forms.BATextBox txtSpoNMSub;
        private Framework.Windows.Forms.BATextBox txtSpoNMAbr;
        private Framework.Windows.Forms.BATextBox txtSpoNMAbrSub;
        private Framework.Windows.Forms.BAToolStripButton cmdOK;
        private Framework.Windows.Forms.BAToolStripButton cmdCancel;
        private Framework.Windows.Forms.BAToolStripButton cmdPrint;
        private Framework.Windows.Forms.BAToolStripButton cmdClose;
        private System.Windows.Forms.BindingSource bsSpoM;
        private TDMST_SpoM dsMain;
        private Framework.Windows.Forms.BADataControl dctSpoM;
        private Framework.Windows.Forms.BABindingNavigator pnlToolbarBtm;
        private Framework.Windows.Forms.BAToolStripButton cmdAddLin;
        private Framework.Windows.Forms.BAToolStripButton cmdCancelLin;
        private Framework.Windows.Forms.BAToolStripButton cmdCopyLin;
        private Framework.Windows.Forms.BAToolStripButton cmdDeleteLin;
        private Framework.Windows.Forms.BAToolStripButton cmdTopLin;
        private Framework.Windows.Forms.BAToolStripButton cmdPrevLin;
        private Framework.Windows.Forms.BAToolStripButton cmdNextLin;
        private Framework.Windows.Forms.BAToolStripButton cmdBotLin;
        private Framework.Windows.Forms.BAToolStripButton cmdLogDspSpoM;
        private Framework.Windows.Forms.BADataGridViewTextBoxColumn dgrSpoMSPOCD;
        private Framework.Windows.Forms.BADataGridViewTextBoxColumn dgrSpoMSPONM;
        private Framework.Windows.Forms.BADataGridViewTextBoxColumn dgrSpoMSPONMABR;
        private Framework.Windows.Forms.BADataGridViewTextBoxColumn dgrSpoMSPONMSUB;
        private Framework.Windows.Forms.BADataGridViewTextBoxColumn dgrSpoMSPONMABRSUB;
        private Framework.Windows.Forms.BADataGridViewTextBoxColumn dgrSpoMDSPORD;
        private Framework.Windows.Forms.BADataGridViewComboBoxColumn dgrSpoMNOUSEST;
        private Framework.Windows.Forms.BALookupComboBox cboNoUseST;
    }
}
