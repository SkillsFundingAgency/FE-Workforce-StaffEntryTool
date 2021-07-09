
using System.ComponentModel;
using System.Windows.Forms;
using ESFA.FE.StaffEntry.Control;

namespace ESFA.FE.StaffEntry
{
    partial class GridView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridView));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.grid = new System.Windows.Forms.DataGridView();
            this.MessageStaffData_FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MessageStaffData_LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MessageStaffData_DateOfBirth = new ESFA.FE.StaffEntry.Control.DataGridViewMaskedTextColumn();
            this.MessageStaffData_Gender = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.MessageStaffData_Ethnicity = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.MessageStaffData_Disability = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.MessageStaffData_MainRole = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.MessageStaffDataRole_Role_1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MessageStaffDataRole_Role_2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MessageStaffDataRole_Role_3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MessageStaffDataRole_Role_4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MessageStaffDataRole_Role_5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MessageStaffData_MostSeniorLeader = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.MessageStaffData_FTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MessageStaffData_CampusID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MessageStaffDataTeacherData_MainSubjectTaught = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.MessageStaffDataTeacherData_HighestQualificationTaught = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.MessageStaffDataTeacherData_HighestQualificationEnglish = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.MessageStaffDataTeacherData_HighestQualificationMaths = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.MessageStaffDataTeacherData_HighestTeachingQualification = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.MessageStaffDataTeacherData_TeacherQualificationStudied = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.MessageStaffDataTeacherData_TeacherQualificationFunding = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.MessageStaffDataTeacherData_ProfessionalTeachingStatus = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.MessageStaffDataTeacherData_IndustryExperienceDuration = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.MessageStaffDataTeacherData_CurrentIndustryExperience = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.MessageStaffDataMainContract_AnnualSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MessageStaffDataMainContract_HourlyRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MessageStaffDataMainContract_WeekContractedHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MessageStaffDataMainContract_ContractType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.MessageStaffData_NumberContracts = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.MessageStaffData_EmploymentStartDate = new ESFA.FE.StaffEntry.Control.DataGridViewMaskedTextColumn();
            this.MessageStaffData_EmploymentEndDate = new ESFA.FE.StaffEntry.Control.DataGridViewMaskedTextColumn();
            this.MessageStaffData_CurrentPositionDuration = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.MessageStaffData_FurtherEducationDuration = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.MessageStaffData_ReasonForLeaving = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.gridContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.showErrorsWarningsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonOpenFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonExport = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonCopy = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPasteItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPasteNewRows = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonDeleteRow = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDeleteAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonFilterAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFilterWarnings = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFilterErrors = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonFreezeColumns = new System.Windows.Forms.ToolStripButton();
            this.ApplicationVersion = new System.Windows.Forms.Label();
            this.collectionYear = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ukprn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openWorkforceDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveWorkforceDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportForUploadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItemCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteItemToolStripMenuPasteItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteAsnewRowsToolStripMenuPasteAsNewRows = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSelectedRowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAllDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFilterAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFilterWarnings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFilterErrors = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.freezeFirstAndLastNameColumnsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewMaskedTextColumn1 = new ESFA.FE.StaffEntry.Control.DataGridViewMaskedTextColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewMaskedTextColumn2 = new ESFA.FE.StaffEntry.Control.DataGridViewMaskedTextColumn();
            this.dataGridViewMaskedTextColumn3 = new ESFA.FE.StaffEntry.Control.DataGridViewMaskedTextColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewMaskedTextColumn4 = new ESFA.FE.StaffEntry.Control.DataGridViewMaskedTextColumn();
            this.dataGridViewMaskedTextColumn5 = new ESFA.FE.StaffEntry.Control.DataGridViewMaskedTextColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.gridContextMenu.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ApplicationVersion);
            this.splitContainer1.Panel2.Controls.Add(this.collectionYear);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.ukprn);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(1180, 709);
            this.splitContainer1.SplitterDistance = 655;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.grid);
            this.splitContainer2.Panel2.Controls.Add(this.toolStrip1);
            this.splitContainer2.Size = new System.Drawing.Size(1180, 655);
            this.splitContainer2.SplitterDistance = 25;
            this.splitContainer2.TabIndex = 1;
            // 
            // grid
            // 
            this.grid.AllowDrop = true;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MessageStaffData_FirstName,
            this.MessageStaffData_LastName,
            this.MessageStaffData_DateOfBirth,
            this.MessageStaffData_Gender,
            this.MessageStaffData_Ethnicity,
            this.MessageStaffData_Disability,
            this.MessageStaffData_MainRole,
            this.MessageStaffDataRole_Role_1,
            this.MessageStaffDataRole_Role_2,
            this.MessageStaffDataRole_Role_3,
            this.MessageStaffDataRole_Role_4,
            this.MessageStaffDataRole_Role_5,
            this.MessageStaffData_MostSeniorLeader,
            this.MessageStaffData_FTE,
            this.MessageStaffData_CampusID,
            this.MessageStaffDataTeacherData_MainSubjectTaught,
            this.MessageStaffDataTeacherData_HighestQualificationTaught,
            this.MessageStaffDataTeacherData_HighestQualificationEnglish,
            this.MessageStaffDataTeacherData_HighestQualificationMaths,
            this.MessageStaffDataTeacherData_HighestTeachingQualification,
            this.MessageStaffDataTeacherData_TeacherQualificationStudied,
            this.MessageStaffDataTeacherData_TeacherQualificationFunding,
            this.MessageStaffDataTeacherData_ProfessionalTeachingStatus,
            this.MessageStaffDataTeacherData_IndustryExperienceDuration,
            this.MessageStaffDataTeacherData_CurrentIndustryExperience,
            this.MessageStaffDataMainContract_AnnualSalary,
            this.MessageStaffDataMainContract_HourlyRate,
            this.MessageStaffDataMainContract_WeekContractedHours,
            this.MessageStaffDataMainContract_ContractType,
            this.MessageStaffData_NumberContracts,
            this.MessageStaffData_EmploymentStartDate,
            this.MessageStaffData_EmploymentEndDate,
            this.MessageStaffData_CurrentPositionDuration,
            this.MessageStaffData_FurtherEducationDuration,
            this.MessageStaffData_ReasonForLeaving});
            this.grid.ContextMenuStrip = this.gridContextMenu;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 25);
            this.grid.Name = "grid";
            this.grid.RowHeadersWidth = 82;
            this.grid.Size = new System.Drawing.Size(1180, 601);
            this.grid.TabIndex = 1;
            this.grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellContentClick);
            this.grid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellEndEdit);
            this.grid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellValueChanged);
            this.grid.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.grid_EditingControlShowing);
            this.grid.MouseUp += new System.Windows.Forms.MouseEventHandler(this.grid_MouseUp);
            // 
            // MessageStaffData_FirstName
            // 
            this.MessageStaffData_FirstName.HeaderText = "First Name";
            this.MessageStaffData_FirstName.MinimumWidth = 10;
            this.MessageStaffData_FirstName.Name = "MessageStaffData_FirstName";
            this.MessageStaffData_FirstName.Width = 200;
            // 
            // MessageStaffData_LastName
            // 
            this.MessageStaffData_LastName.HeaderText = "Last Name";
            this.MessageStaffData_LastName.MinimumWidth = 10;
            this.MessageStaffData_LastName.Name = "MessageStaffData_LastName";
            this.MessageStaffData_LastName.Width = 200;
            // 
            // MessageStaffData_DateOfBirth
            // 
            this.MessageStaffData_DateOfBirth.HeaderText = "Date Of Birth";
            this.MessageStaffData_DateOfBirth.Mask = "00/00/0000";
            this.MessageStaffData_DateOfBirth.MinimumWidth = 10;
            this.MessageStaffData_DateOfBirth.Name = "MessageStaffData_DateOfBirth";
            this.MessageStaffData_DateOfBirth.Width = 200;
            // 
            // MessageStaffData_Gender
            // 
            this.MessageStaffData_Gender.DropDownWidth = 100;
            this.MessageStaffData_Gender.HeaderText = "Gender";
            this.MessageStaffData_Gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Identifies in another way",
            "Prefer not to say"});
            this.MessageStaffData_Gender.MinimumWidth = 100;
            this.MessageStaffData_Gender.Name = "MessageStaffData_Gender";
            this.MessageStaffData_Gender.Width = 150;
            // 
            // MessageStaffData_Ethnicity
            // 
            this.MessageStaffData_Ethnicity.HeaderText = "Ethnicity";
            this.MessageStaffData_Ethnicity.Items.AddRange(new object[] {
            "English, Welsh, Scottish, Northern Irish or British",
            "Irish",
            "Gypsy or Irish Traveller",
            "Any Other White background",
            "White and Black Caribbean",
            "White and Black African",
            "White and Asian",
            "Any Other Mixed or Multiple background",
            "Indian",
            "Pakistani",
            "Bangladeshi",
            "Chinese",
            "Any other Asian background",
            "African background",
            "Caribbean",
            "Any other Black, Black British or Caribbean background",
            "Arab",
            "Roma",
            "Any other ethnic group",
            "Not provided"});
            this.MessageStaffData_Ethnicity.MinimumWidth = 250;
            this.MessageStaffData_Ethnicity.Name = "MessageStaffData_Ethnicity";
            this.MessageStaffData_Ethnicity.Width = 250;
            // 
            // MessageStaffData_Disability
            // 
            this.MessageStaffData_Disability.HeaderText = "Disability";
            this.MessageStaffData_Disability.Items.AddRange(new object[] {
            "Yes",
            "No",
            "Prefer not to say"});
            this.MessageStaffData_Disability.MinimumWidth = 10;
            this.MessageStaffData_Disability.Name = "MessageStaffData_Disability";
            this.MessageStaffData_Disability.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MessageStaffData_Disability.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.MessageStaffData_Disability.Width = 93;
            // 
            // MessageStaffData_MainRole
            // 
            this.MessageStaffData_MainRole.HeaderText = "Main Role";
            this.MessageStaffData_MainRole.Items.AddRange(new object[] {
            "Senior Leader",
            "Manager",
            "Teacher",
            "Teaching Support",
            "Administration"});
            this.MessageStaffData_MainRole.MinimumWidth = 100;
            this.MessageStaffData_MainRole.Name = "MessageStaffData_MainRole";
            this.MessageStaffData_MainRole.Width = 150;
            // 
            // MessageStaffDataRole_Role_1
            // 
            this.MessageStaffDataRole_Role_1.HeaderText = "Is Senior Leader";
            this.MessageStaffDataRole_Role_1.MinimumWidth = 10;
            this.MessageStaffDataRole_Role_1.Name = "MessageStaffDataRole_Role_1";
            this.MessageStaffDataRole_Role_1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MessageStaffDataRole_Role_1.Width = 200;
            // 
            // MessageStaffDataRole_Role_2
            // 
            this.MessageStaffDataRole_Role_2.HeaderText = "Is Manager";
            this.MessageStaffDataRole_Role_2.MinimumWidth = 10;
            this.MessageStaffDataRole_Role_2.Name = "MessageStaffDataRole_Role_2";
            this.MessageStaffDataRole_Role_2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MessageStaffDataRole_Role_2.Width = 200;
            // 
            // MessageStaffDataRole_Role_3
            // 
            this.MessageStaffDataRole_Role_3.HeaderText = "Is Teacher";
            this.MessageStaffDataRole_Role_3.MinimumWidth = 10;
            this.MessageStaffDataRole_Role_3.Name = "MessageStaffDataRole_Role_3";
            this.MessageStaffDataRole_Role_3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MessageStaffDataRole_Role_3.Width = 200;
            // 
            // MessageStaffDataRole_Role_4
            // 
            this.MessageStaffDataRole_Role_4.HeaderText = "Is Teaching Support";
            this.MessageStaffDataRole_Role_4.MinimumWidth = 10;
            this.MessageStaffDataRole_Role_4.Name = "MessageStaffDataRole_Role_4";
            this.MessageStaffDataRole_Role_4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MessageStaffDataRole_Role_4.Width = 200;
            // 
            // MessageStaffDataRole_Role_5
            // 
            this.MessageStaffDataRole_Role_5.HeaderText = "Is Administration";
            this.MessageStaffDataRole_Role_5.MinimumWidth = 10;
            this.MessageStaffDataRole_Role_5.Name = "MessageStaffDataRole_Role_5";
            this.MessageStaffDataRole_Role_5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MessageStaffDataRole_Role_5.Width = 200;
            // 
            // MessageStaffData_MostSeniorLeader
            // 
            this.MessageStaffData_MostSeniorLeader.HeaderText = "Most Senior Leader";
            this.MessageStaffData_MostSeniorLeader.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.MessageStaffData_MostSeniorLeader.MinimumWidth = 8;
            this.MessageStaffData_MostSeniorLeader.Name = "MessageStaffData_MostSeniorLeader";
            this.MessageStaffData_MostSeniorLeader.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MessageStaffData_MostSeniorLeader.Width = 150;
            // 
            // MessageStaffData_FTE
            // 
            this.MessageStaffData_FTE.HeaderText = "FTE";
            this.MessageStaffData_FTE.MaxInputLength = 4;
            this.MessageStaffData_FTE.MinimumWidth = 10;
            this.MessageStaffData_FTE.Name = "MessageStaffData_FTE";
            this.MessageStaffData_FTE.Width = 200;
            // 
            // MessageStaffData_CampusID
            // 
            this.MessageStaffData_CampusID.HeaderText = "Campus ID";
            this.MessageStaffData_CampusID.MinimumWidth = 10;
            this.MessageStaffData_CampusID.Name = "MessageStaffData_CampusID";
            this.MessageStaffData_CampusID.Width = 200;
            // 
            // MessageStaffDataTeacherData_MainSubjectTaught
            // 
            this.MessageStaffDataTeacherData_MainSubjectTaught.HeaderText = "Main Subject Taught";
            this.MessageStaffDataTeacherData_MainSubjectTaught.Items.AddRange(new object[] {
            "Ancient Languages",
            "Archaeology",
            "Astronomy",
            "Art and Design, History of Art",
            "Biology",
            "Chemistry",
            "Citizenship studies",
            "Classical studies",
            "Computer science",
            "Dance, drama and theatre",
            "Design, technology and engineering",
            "Electronics",
            "English",
            "Environmental science",
            "Film and media studies",
            "Food preparation and nutrition",
            "Geography",
            "Geology",
            "History",
            "Mathematics",
            "Modern foreign languages",
            "Music",
            "Physical education",
            "Philosophy",
            "Physics",
            "Politics",
            "Psychology",
            "Religious studies",
            "Sociology",
            "Accounting and Finance",
            "Agriculture and Horticulture",
            "Animal Care",
            "Business Management and Administration",
            "Catering and Hospitality",
            "Construction, Planning and the Built Environment",
            "Crafts, Creative Arts and Design",
            "Design, Engineering and Manufacturing",
            "Digital / ICT",
            "Education and Childcare",
            "Education and Training",
            "Environmental",
            "Hair, Beauty and Aesthetics",
            "Health, Public Services and Care",
            "Law and Legal Services",
            "Media, Broadcast and Production",
            "Performing Arts",
            "Retail and Commercial Enterprise",
            "Science",
            "Sport, Leisure and Recreation",
            "Transport and Logistics",
            "Travel and Tourism",
            "Functional Skills (English, Maths and IT)",
            "Life Skills",
            "Preparation for Work",
            "Supported Learning or Special Educational Needs learning provision",
            "ESOL",
            "Community Learning",
            "Family Learning",
            "Other"});
            this.MessageStaffDataTeacherData_MainSubjectTaught.MinimumWidth = 200;
            this.MessageStaffDataTeacherData_MainSubjectTaught.Name = "MessageStaffDataTeacherData_MainSubjectTaught";
            this.MessageStaffDataTeacherData_MainSubjectTaught.Width = 200;
            // 
            // MessageStaffDataTeacherData_HighestQualificationTaught
            // 
            this.MessageStaffDataTeacherData_HighestQualificationTaught.HeaderText = "Highest Taught";
            this.MessageStaffDataTeacherData_HighestQualificationTaught.Items.AddRange(new object[] {
            "Level 1",
            "Level 2",
            "Level 3",
            "Level 4",
            "Level 5",
            "Level 6",
            "Level 7",
            "Level 8",
            "Entry level",
            "Other"});
            this.MessageStaffDataTeacherData_HighestQualificationTaught.MinimumWidth = 250;
            this.MessageStaffDataTeacherData_HighestQualificationTaught.Name = "MessageStaffDataTeacherData_HighestQualificationTaught";
            this.MessageStaffDataTeacherData_HighestQualificationTaught.Width = 250;
            // 
            // MessageStaffDataTeacherData_HighestQualificationEnglish
            // 
            this.MessageStaffDataTeacherData_HighestQualificationEnglish.HeaderText = "Highest English";
            this.MessageStaffDataTeacherData_HighestQualificationEnglish.Items.AddRange(new object[] {
            "Level 2",
            "Level 3",
            "Level 4",
            "Level 5",
            "Level 6",
            "Level 7",
            "Level 8",
            "Other",
            "None",
            "Not Known "});
            this.MessageStaffDataTeacherData_HighestQualificationEnglish.MinimumWidth = 250;
            this.MessageStaffDataTeacherData_HighestQualificationEnglish.Name = "MessageStaffDataTeacherData_HighestQualificationEnglish";
            this.MessageStaffDataTeacherData_HighestQualificationEnglish.Width = 250;
            // 
            // MessageStaffDataTeacherData_HighestQualificationMaths
            // 
            this.MessageStaffDataTeacherData_HighestQualificationMaths.HeaderText = "HighestMaths";
            this.MessageStaffDataTeacherData_HighestQualificationMaths.Items.AddRange(new object[] {
            "Level 2",
            "Level 3",
            "Level 4",
            "Level 5",
            "Level 6",
            "Level 7",
            "Level 8",
            "Other",
            "None",
            "Not Known "});
            this.MessageStaffDataTeacherData_HighestQualificationMaths.MinimumWidth = 250;
            this.MessageStaffDataTeacherData_HighestQualificationMaths.Name = "MessageStaffDataTeacherData_HighestQualificationMaths";
            this.MessageStaffDataTeacherData_HighestQualificationMaths.Width = 250;
            // 
            // MessageStaffDataTeacherData_HighestTeachingQualification
            // 
            this.MessageStaffDataTeacherData_HighestTeachingQualification.HeaderText = "Highest Teaching Qualification";
            this.MessageStaffDataTeacherData_HighestTeachingQualification.Items.AddRange(new object[] {
            "Level 3",
            "Level 4",
            "Level 5",
            "Level 6",
            "Level 7",
            "Level 8",
            "Other",
            "None",
            "Not Known ",
            "Working towards a teacher training qualification"});
            this.MessageStaffDataTeacherData_HighestTeachingQualification.MinimumWidth = 250;
            this.MessageStaffDataTeacherData_HighestTeachingQualification.Name = "MessageStaffDataTeacherData_HighestTeachingQualification";
            this.MessageStaffDataTeacherData_HighestTeachingQualification.Width = 250;
            // 
            // MessageStaffDataTeacherData_TeacherQualificationStudied
            // 
            this.MessageStaffDataTeacherData_TeacherQualificationStudied.HeaderText = "Teacher Qualification Studied";
            this.MessageStaffDataTeacherData_TeacherQualificationStudied.Items.AddRange(new object[] {
            "Level 3",
            "Level 4",
            "Level 5",
            "Level 6",
            "Level 7",
            "Other"});
            this.MessageStaffDataTeacherData_TeacherQualificationStudied.MinimumWidth = 250;
            this.MessageStaffDataTeacherData_TeacherQualificationStudied.Name = "MessageStaffDataTeacherData_TeacherQualificationStudied";
            this.MessageStaffDataTeacherData_TeacherQualificationStudied.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MessageStaffDataTeacherData_TeacherQualificationStudied.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.MessageStaffDataTeacherData_TeacherQualificationStudied.Width = 250;
            // 
            // MessageStaffDataTeacherData_TeacherQualificationFunding
            // 
            this.MessageStaffDataTeacherData_TeacherQualificationFunding.HeaderText = "Teacher Qualification Funding";
            this.MessageStaffDataTeacherData_TeacherQualificationFunding.Items.AddRange(new object[] {
            "Yes, we’re paying for all of it ",
            "Yes, we’re paying for some of it",
            "No"});
            this.MessageStaffDataTeacherData_TeacherQualificationFunding.MinimumWidth = 250;
            this.MessageStaffDataTeacherData_TeacherQualificationFunding.Name = "MessageStaffDataTeacherData_TeacherQualificationFunding";
            this.MessageStaffDataTeacherData_TeacherQualificationFunding.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MessageStaffDataTeacherData_TeacherQualificationFunding.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.MessageStaffDataTeacherData_TeacherQualificationFunding.Width = 250;
            // 
            // MessageStaffDataTeacherData_ProfessionalTeachingStatus
            // 
            this.MessageStaffDataTeacherData_ProfessionalTeachingStatus.HeaderText = "Professional Teaching Status";
            this.MessageStaffDataTeacherData_ProfessionalTeachingStatus.Items.AddRange(new object[] {
            "QTS",
            "QTLS",
            "Advanced teacher status",
            "Chartered teacher status",
            "Other",
            "None "});
            this.MessageStaffDataTeacherData_ProfessionalTeachingStatus.MinimumWidth = 250;
            this.MessageStaffDataTeacherData_ProfessionalTeachingStatus.Name = "MessageStaffDataTeacherData_ProfessionalTeachingStatus";
            this.MessageStaffDataTeacherData_ProfessionalTeachingStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MessageStaffDataTeacherData_ProfessionalTeachingStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.MessageStaffDataTeacherData_ProfessionalTeachingStatus.Width = 250;
            // 
            // MessageStaffDataTeacherData_IndustryExperienceDuration
            // 
            this.MessageStaffDataTeacherData_IndustryExperienceDuration.HeaderText = "Industry Experience Duration";
            this.MessageStaffDataTeacherData_IndustryExperienceDuration.Items.AddRange(new object[] {
            "Less than one year",
            "1 to 3 years",
            "4 to 10 years",
            "11 to 20 years",
            "Over 20 years",
            "They haven\'t had industry experience",
            "Not known "});
            this.MessageStaffDataTeacherData_IndustryExperienceDuration.MinimumWidth = 250;
            this.MessageStaffDataTeacherData_IndustryExperienceDuration.Name = "MessageStaffDataTeacherData_IndustryExperienceDuration";
            this.MessageStaffDataTeacherData_IndustryExperienceDuration.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MessageStaffDataTeacherData_IndustryExperienceDuration.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.MessageStaffDataTeacherData_IndustryExperienceDuration.Width = 250;
            // 
            // MessageStaffDataTeacherData_CurrentIndustryExperience
            // 
            this.MessageStaffDataTeacherData_CurrentIndustryExperience.HeaderText = "Current Industry Experience";
            this.MessageStaffDataTeacherData_CurrentIndustryExperience.Items.AddRange(new object[] {
            "Yes",
            "No",
            "Not known "});
            this.MessageStaffDataTeacherData_CurrentIndustryExperience.MinimumWidth = 250;
            this.MessageStaffDataTeacherData_CurrentIndustryExperience.Name = "MessageStaffDataTeacherData_CurrentIndustryExperience";
            this.MessageStaffDataTeacherData_CurrentIndustryExperience.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MessageStaffDataTeacherData_CurrentIndustryExperience.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.MessageStaffDataTeacherData_CurrentIndustryExperience.Width = 250;
            // 
            // MessageStaffDataMainContract_AnnualSalary
            // 
            this.MessageStaffDataMainContract_AnnualSalary.HeaderText = "Annual Salary";
            this.MessageStaffDataMainContract_AnnualSalary.MaxInputLength = 7;
            this.MessageStaffDataMainContract_AnnualSalary.MinimumWidth = 10;
            this.MessageStaffDataMainContract_AnnualSalary.Name = "MessageStaffDataMainContract_AnnualSalary";
            this.MessageStaffDataMainContract_AnnualSalary.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MessageStaffDataMainContract_AnnualSalary.Width = 200;
            // 
            // MessageStaffDataMainContract_HourlyRate
            // 
            this.MessageStaffDataMainContract_HourlyRate.HeaderText = "Hourly Rate";
            this.MessageStaffDataMainContract_HourlyRate.MaxInputLength = 6;
            this.MessageStaffDataMainContract_HourlyRate.MinimumWidth = 10;
            this.MessageStaffDataMainContract_HourlyRate.Name = "MessageStaffDataMainContract_HourlyRate";
            this.MessageStaffDataMainContract_HourlyRate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MessageStaffDataMainContract_HourlyRate.Width = 200;
            // 
            // MessageStaffDataMainContract_WeekContractedHours
            // 
            this.MessageStaffDataMainContract_WeekContractedHours.HeaderText = "Week Contracted Hours";
            this.MessageStaffDataMainContract_WeekContractedHours.MaxInputLength = 6;
            this.MessageStaffDataMainContract_WeekContractedHours.MinimumWidth = 10;
            this.MessageStaffDataMainContract_WeekContractedHours.Name = "MessageStaffDataMainContract_WeekContractedHours";
            this.MessageStaffDataMainContract_WeekContractedHours.Width = 200;
            // 
            // MessageStaffDataMainContract_ContractType
            // 
            this.MessageStaffDataMainContract_ContractType.HeaderText = "Contract Type";
            this.MessageStaffDataMainContract_ContractType.Items.AddRange(new object[] {
            "Permanent",
            "Fixed term ",
            "Variable hours",
            "Zero hours ",
            "Other"});
            this.MessageStaffDataMainContract_ContractType.MinimumWidth = 250;
            this.MessageStaffDataMainContract_ContractType.Name = "MessageStaffDataMainContract_ContractType";
            this.MessageStaffDataMainContract_ContractType.Width = 250;
            // 
            // MessageStaffData_NumberContracts
            // 
            this.MessageStaffData_NumberContracts.HeaderText = "Number Contracts";
            this.MessageStaffData_NumberContracts.Items.AddRange(new object[] {
            "One ",
            "More than one "});
            this.MessageStaffData_NumberContracts.MinimumWidth = 200;
            this.MessageStaffData_NumberContracts.Name = "MessageStaffData_NumberContracts";
            this.MessageStaffData_NumberContracts.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MessageStaffData_NumberContracts.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.MessageStaffData_NumberContracts.Width = 200;
            // 
            // MessageStaffData_EmploymentStartDate
            // 
            this.MessageStaffData_EmploymentStartDate.HeaderText = "Employment Start Date";
            this.MessageStaffData_EmploymentStartDate.Mask = "00/00/0000";
            this.MessageStaffData_EmploymentStartDate.MinimumWidth = 10;
            this.MessageStaffData_EmploymentStartDate.Name = "MessageStaffData_EmploymentStartDate";
            this.MessageStaffData_EmploymentStartDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MessageStaffData_EmploymentStartDate.Width = 200;
            // 
            // MessageStaffData_EmploymentEndDate
            // 
            this.MessageStaffData_EmploymentEndDate.HeaderText = "Employment End Date";
            this.MessageStaffData_EmploymentEndDate.Mask = "00/00/0000";
            this.MessageStaffData_EmploymentEndDate.MinimumWidth = 10;
            this.MessageStaffData_EmploymentEndDate.Name = "MessageStaffData_EmploymentEndDate";
            this.MessageStaffData_EmploymentEndDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MessageStaffData_EmploymentEndDate.Width = 200;
            // 
            // MessageStaffData_CurrentPositionDuration
            // 
            this.MessageStaffData_CurrentPositionDuration.HeaderText = "Current Position Duration";
            this.MessageStaffData_CurrentPositionDuration.Items.AddRange(new object[] {
            "Less than one year",
            "1 to 3 years",
            "4 to 10 years",
            "11 to 20 years",
            "Over 20 years"});
            this.MessageStaffData_CurrentPositionDuration.MinimumWidth = 250;
            this.MessageStaffData_CurrentPositionDuration.Name = "MessageStaffData_CurrentPositionDuration";
            this.MessageStaffData_CurrentPositionDuration.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MessageStaffData_CurrentPositionDuration.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.MessageStaffData_CurrentPositionDuration.Width = 250;
            // 
            // MessageStaffData_FurtherEducationDuration
            // 
            this.MessageStaffData_FurtherEducationDuration.HeaderText = "Further Education Duration";
            this.MessageStaffData_FurtherEducationDuration.Items.AddRange(new object[] {
            "Less than one year",
            "1 to 3 years",
            "4 to 10 years",
            "11 to 20 years",
            "Over 20 years",
            "Not known"});
            this.MessageStaffData_FurtherEducationDuration.MinimumWidth = 250;
            this.MessageStaffData_FurtherEducationDuration.Name = "MessageStaffData_FurtherEducationDuration";
            this.MessageStaffData_FurtherEducationDuration.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MessageStaffData_FurtherEducationDuration.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.MessageStaffData_FurtherEducationDuration.Width = 250;
            // 
            // MessageStaffData_ReasonForLeaving
            // 
            this.MessageStaffData_ReasonForLeaving.HeaderText = "Reason For Leaving";
            this.MessageStaffData_ReasonForLeaving.Items.AddRange(new object[] {
            "Resignation - job change outside of education",
            "Resignation - job change within FE sector",
            "Resignation - job change within education but not FE",
            "Resignation - career break",
            "Resignation - other",
            "End of Contract",
            "Retirement",
            "Redundancy – voluntary",
            "Redundancy – compulsory",
            "Deceased",
            "Other"});
            this.MessageStaffData_ReasonForLeaving.MinimumWidth = 250;
            this.MessageStaffData_ReasonForLeaving.Name = "MessageStaffData_ReasonForLeaving";
            this.MessageStaffData_ReasonForLeaving.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MessageStaffData_ReasonForLeaving.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.MessageStaffData_ReasonForLeaving.Width = 250;
            // 
            // gridContextMenu
            // 
            this.gridContextMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.gridContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteItemToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator6,
            this.deleteStripMenuItem,
            this.toolStripSeparator7,
            this.showErrorsWarningsToolStripMenuItem});
            this.gridContextMenu.Name = "gridContextMenu";
            this.gridContextMenu.Size = new System.Drawing.Size(192, 148);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = global::ESFA.FE.StaffEntry.Properties.Resources.Copy_16x;
            this.copyToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteItemToolStripMenuItem
            // 
            this.pasteItemToolStripMenuItem.Image = global::ESFA.FE.StaffEntry.Properties.Resources.Paste_16x;
            this.pasteItemToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.pasteItemToolStripMenuItem.Name = "pasteItemToolStripMenuItem";
            this.pasteItemToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.pasteItemToolStripMenuItem.Text = "Paste& item(s)";
            this.pasteItemToolStripMenuItem.Click += new System.EventHandler(this.pasteItemToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = global::ESFA.FE.StaffEntry.Properties.Resources.PasteTable_16x;
            this.pasteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.pasteToolStripMenuItem.Text = "Paste as &new row(s)";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(188, 6);
            // 
            // deleteStripMenuItem
            // 
            this.deleteStripMenuItem.Image = global::ESFA.FE.StaffEntry.Properties.Resources.DeleteTableRow_16x;
            this.deleteStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteStripMenuItem.Name = "deleteStripMenuItem";
            this.deleteStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.deleteStripMenuItem.Text = "Delete &selected row(s)";
            this.deleteStripMenuItem.Click += new System.EventHandler(this.deleteStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(188, 6);
            // 
            // showErrorsWarningsToolStripMenuItem
            // 
            this.showErrorsWarningsToolStripMenuItem.Image = global::ESFA.FE.StaffEntry.Properties.Resources.ErrorSummary_16x;
            this.showErrorsWarningsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showErrorsWarningsToolStripMenuItem.Name = "showErrorsWarningsToolStripMenuItem";
            this.showErrorsWarningsToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.showErrorsWarningsToolStripMenuItem.Text = "Show Errors/Warnings";
            this.showErrorsWarningsToolStripMenuItem.Click += new System.EventHandler(this.showErrorsWarningsToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonOpenFile,
            this.toolStripButtonSave,
            this.toolStripButtonExport,
            this.toolStripSeparator1,
            this.toolStripButtonCopy,
            this.toolStripButtonPasteItem,
            this.toolStripButtonPasteNewRows,
            this.toolStripSeparator2,
            this.toolStripButtonDeleteRow,
            this.toolStripButtonDeleteAll,
            this.toolStripSeparator3,
            this.toolStripButtonFilterAll,
            this.toolStripButtonFilterWarnings,
            this.toolStripButtonFilterErrors,
            this.toolStripSeparator5,
            this.toolStripButtonFreezeColumns});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1180, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonOpenFile
            // 
            this.toolStripButtonOpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonOpenFile.Image = global::ESFA.FE.StaffEntry.Properties.Resources.OpenFile_16x;
            this.toolStripButtonOpenFile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonOpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpenFile.Name = "toolStripButtonOpenFile";
            this.toolStripButtonOpenFile.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonOpenFile.Text = "Open file";
            this.toolStripButtonOpenFile.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSave.Image = global::ESFA.FE.StaffEntry.Properties.Resources.Save_16x;
            this.toolStripButtonSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSave.Text = "toolStripButtonSave";
            this.toolStripButtonSave.ToolTipText = "Save data";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButtonExport
            // 
            this.toolStripButtonExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonExport.Image = global::ESFA.FE.StaffEntry.Properties.Resources.CloudUpload_16x;
            this.toolStripButtonExport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonExport.Name = "toolStripButtonExport";
            this.toolStripButtonExport.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonExport.Text = "toolStripButtonExport";
            this.toolStripButtonExport.ToolTipText = "Export data";
            this.toolStripButtonExport.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonCopy
            // 
            this.toolStripButtonCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCopy.Image = global::ESFA.FE.StaffEntry.Properties.Resources.Copy_16x;
            this.toolStripButtonCopy.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCopy.Name = "toolStripButtonCopy";
            this.toolStripButtonCopy.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonCopy.Text = "Copy selected cell(s)";
            this.toolStripButtonCopy.Click += new System.EventHandler(this.toolStripButtonCopy_Click);
            // 
            // toolStripButtonPasteItem
            // 
            this.toolStripButtonPasteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPasteItem.Image = global::ESFA.FE.StaffEntry.Properties.Resources.Paste_16x;
            this.toolStripButtonPasteItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonPasteItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPasteItem.Name = "toolStripButtonPasteItem";
            this.toolStripButtonPasteItem.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonPasteItem.Text = "Paste item";
            this.toolStripButtonPasteItem.Click += new System.EventHandler(this.toolStripButtonPasteItem_Click);
            // 
            // toolStripButtonPasteNewRows
            // 
            this.toolStripButtonPasteNewRows.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPasteNewRows.Image = global::ESFA.FE.StaffEntry.Properties.Resources.PasteTable_16x;
            this.toolStripButtonPasteNewRows.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonPasteNewRows.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPasteNewRows.Name = "toolStripButtonPasteNewRows";
            this.toolStripButtonPasteNewRows.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonPasteNewRows.Text = "Paste as new row(s)";
            this.toolStripButtonPasteNewRows.Click += new System.EventHandler(this.toolStripButtonPasteNewRows_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonDeleteRow
            // 
            this.toolStripButtonDeleteRow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDeleteRow.Image = global::ESFA.FE.StaffEntry.Properties.Resources.DeleteTableRow_16x;
            this.toolStripButtonDeleteRow.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonDeleteRow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDeleteRow.Name = "toolStripButtonDeleteRow";
            this.toolStripButtonDeleteRow.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonDeleteRow.Text = "Delete selected row(s)";
            this.toolStripButtonDeleteRow.ToolTipText = "Delete selected row(s)";
            this.toolStripButtonDeleteRow.Click += new System.EventHandler(this.toolStripButtonDeleteRow_Click);
            // 
            // toolStripButtonDeleteAll
            // 
            this.toolStripButtonDeleteAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDeleteAll.Image = global::ESFA.FE.StaffEntry.Properties.Resources.DeleteAllRows_16x;
            this.toolStripButtonDeleteAll.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonDeleteAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDeleteAll.Name = "toolStripButtonDeleteAll";
            this.toolStripButtonDeleteAll.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonDeleteAll.Text = "toolStripButtonDeleteAll";
            this.toolStripButtonDeleteAll.ToolTipText = "Delete all data";
            this.toolStripButtonDeleteAll.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonFilterAll
            // 
            this.toolStripButtonFilterAll.Checked = true;
            this.toolStripButtonFilterAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripButtonFilterAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFilterAll.Image = global::ESFA.FE.StaffEntry.Properties.Resources.Aggregate_16x;
            this.toolStripButtonFilterAll.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonFilterAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFilterAll.Name = "toolStripButtonFilterAll";
            this.toolStripButtonFilterAll.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonFilterAll.Text = "Show all rows";
            this.toolStripButtonFilterAll.Click += new System.EventHandler(this.toolStripButtonFilterAll_Click);
            // 
            // toolStripButtonFilterWarnings
            // 
            this.toolStripButtonFilterWarnings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFilterWarnings.Image = global::ESFA.FE.StaffEntry.Properties.Resources.AggregateWarning_16x;
            this.toolStripButtonFilterWarnings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonFilterWarnings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFilterWarnings.Name = "toolStripButtonFilterWarnings";
            this.toolStripButtonFilterWarnings.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonFilterWarnings.Text = "Show only rows with warnings";
            this.toolStripButtonFilterWarnings.Click += new System.EventHandler(this.toolStripButtonFilterWarnings_Click);
            // 
            // toolStripButtonFilterErrors
            // 
            this.toolStripButtonFilterErrors.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFilterErrors.Image = global::ESFA.FE.StaffEntry.Properties.Resources.AggregateError_16x;
            this.toolStripButtonFilterErrors.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonFilterErrors.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFilterErrors.Name = "toolStripButtonFilterErrors";
            this.toolStripButtonFilterErrors.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonFilterErrors.Text = "Show only rows with errors";
            this.toolStripButtonFilterErrors.Click += new System.EventHandler(this.toolStripButtonFilterErrors_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonFreezeColumns
            // 
            this.toolStripButtonFreezeColumns.CheckOnClick = true;
            this.toolStripButtonFreezeColumns.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFreezeColumns.Image = global::ESFA.FE.StaffEntry.Properties.Resources.TableColumn_16x;
            this.toolStripButtonFreezeColumns.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonFreezeColumns.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFreezeColumns.Name = "toolStripButtonFreezeColumns";
            this.toolStripButtonFreezeColumns.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonFreezeColumns.Text = "Freeze first and last name columns";
            this.toolStripButtonFreezeColumns.CheckedChanged += new System.EventHandler(this.toolStripButtonFreezeColumns_CheckedChanged);
            // 
            // ApplicationVersion
            // 
            this.ApplicationVersion.AccessibleDescription = "Version number information for the application";
            this.ApplicationVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ApplicationVersion.Location = new System.Drawing.Point(817, 28);
            this.ApplicationVersion.Name = "ApplicationVersion";
            this.ApplicationVersion.Size = new System.Drawing.Size(351, 13);
            this.ApplicationVersion.TabIndex = 4;
            this.ApplicationVersion.Text = "<<version>>";
            this.ApplicationVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // collectionYear
            // 
            this.collectionYear.Location = new System.Drawing.Point(246, 15);
            this.collectionYear.MaxLength = 4;
            this.collectionYear.Name = "collectionYear";
            this.collectionYear.Size = new System.Drawing.Size(100, 20);
            this.collectionYear.TabIndex = 3;
            this.collectionYear.Visible = false;
            this.collectionYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IsNumeric_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Year";
            this.label2.Visible = false;
            // 
            // ukprn
            // 
            this.ukprn.Location = new System.Drawing.Point(55, 15);
            this.ukprn.Name = "ukprn";
            this.ukprn.Size = new System.Drawing.Size(100, 20);
            this.ukprn.TabIndex = 1;
            this.ukprn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IsNumeric_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ukprn";
            // 
            // mainMenu
            // 
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.dataToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1180, 24);
            this.mainMenu.TabIndex = 2;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openWorkforceDataToolStripMenuItem,
            this.saveWorkforceDataToolStripMenuItem,
            this.exportForUploadToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openWorkforceDataToolStripMenuItem
            // 
            this.openWorkforceDataToolStripMenuItem.Image = global::ESFA.FE.StaffEntry.Properties.Resources.OpenFile_16x;
            this.openWorkforceDataToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.openWorkforceDataToolStripMenuItem.Name = "openWorkforceDataToolStripMenuItem";
            this.openWorkforceDataToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.openWorkforceDataToolStripMenuItem.Text = "&Open Workforce data";
            this.openWorkforceDataToolStripMenuItem.Click += new System.EventHandler(this.openWorkforceDataToolStripMenuItem_Click);
            // 
            // saveWorkforceDataToolStripMenuItem
            // 
            this.saveWorkforceDataToolStripMenuItem.Image = global::ESFA.FE.StaffEntry.Properties.Resources.Save_16x;
            this.saveWorkforceDataToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.saveWorkforceDataToolStripMenuItem.Name = "saveWorkforceDataToolStripMenuItem";
            this.saveWorkforceDataToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.saveWorkforceDataToolStripMenuItem.Text = "&Save Workforce data";
            this.saveWorkforceDataToolStripMenuItem.Click += new System.EventHandler(this.saveWorkforceDataToolStripMenuItem_Click);
            // 
            // exportForUploadToolStripMenuItem
            // 
            this.exportForUploadToolStripMenuItem.Image = global::ESFA.FE.StaffEntry.Properties.Resources.CloudUpload_16x;
            this.exportForUploadToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.exportForUploadToolStripMenuItem.Name = "exportForUploadToolStripMenuItem";
            this.exportForUploadToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.exportForUploadToolStripMenuItem.Text = "&Export for upload";
            this.exportForUploadToolStripMenuItem.Click += new System.EventHandler(this.exportForUploadToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(184, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::ESFA.FE.StaffEntry.Properties.Resources.Exit_16x;
            this.exitToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItemCopy,
            this.pasteItemToolStripMenuPasteItem,
            this.pasteAsnewRowsToolStripMenuPasteAsNewRows});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // copyToolStripMenuItemCopy
            // 
            this.copyToolStripMenuItemCopy.Image = global::ESFA.FE.StaffEntry.Properties.Resources.Copy_16x;
            this.copyToolStripMenuItemCopy.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.copyToolStripMenuItemCopy.Name = "copyToolStripMenuItemCopy";
            this.copyToolStripMenuItemCopy.Size = new System.Drawing.Size(182, 22);
            this.copyToolStripMenuItemCopy.Text = "&Copy selected cell(s)";
            this.copyToolStripMenuItemCopy.Click += new System.EventHandler(this.copyToolStripMenuItemCopy_Click);
            // 
            // pasteItemToolStripMenuPasteItem
            // 
            this.pasteItemToolStripMenuPasteItem.Image = global::ESFA.FE.StaffEntry.Properties.Resources.Paste_16x;
            this.pasteItemToolStripMenuPasteItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.pasteItemToolStripMenuPasteItem.Name = "pasteItemToolStripMenuPasteItem";
            this.pasteItemToolStripMenuPasteItem.Size = new System.Drawing.Size(182, 22);
            this.pasteItemToolStripMenuPasteItem.Text = "Paste &item(s)";
            this.pasteItemToolStripMenuPasteItem.Click += new System.EventHandler(this.pasteItemToolStripMenuPasteItem_Click);
            // 
            // pasteAsnewRowsToolStripMenuPasteAsNewRows
            // 
            this.pasteAsnewRowsToolStripMenuPasteAsNewRows.Image = global::ESFA.FE.StaffEntry.Properties.Resources.PasteTable_16x;
            this.pasteAsnewRowsToolStripMenuPasteAsNewRows.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.pasteAsnewRowsToolStripMenuPasteAsNewRows.Name = "pasteAsnewRowsToolStripMenuPasteAsNewRows";
            this.pasteAsnewRowsToolStripMenuPasteAsNewRows.Size = new System.Drawing.Size(182, 22);
            this.pasteAsnewRowsToolStripMenuPasteAsNewRows.Text = "Paste as &new row(s)";
            this.pasteAsnewRowsToolStripMenuPasteAsNewRows.Click += new System.EventHandler(this.pasteAsnewRowsToolStripMenuPasteAsNewRows_Click);
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteSelectedRowsToolStripMenuItem,
            this.deleteAllDataToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.dataToolStripMenuItem.Text = "&Data";
            // 
            // deleteSelectedRowsToolStripMenuItem
            // 
            this.deleteSelectedRowsToolStripMenuItem.Image = global::ESFA.FE.StaffEntry.Properties.Resources.DeleteTableRow_16x;
            this.deleteSelectedRowsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteSelectedRowsToolStripMenuItem.Name = "deleteSelectedRowsToolStripMenuItem";
            this.deleteSelectedRowsToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.deleteSelectedRowsToolStripMenuItem.Text = "Delete &selected row(s)";
            this.deleteSelectedRowsToolStripMenuItem.Click += new System.EventHandler(this.deleteSelectedRowsToolStripMenuItem_Click);
            // 
            // deleteAllDataToolStripMenuItem
            // 
            this.deleteAllDataToolStripMenuItem.Image = global::ESFA.FE.StaffEntry.Properties.Resources.DeleteAllRows_16x;
            this.deleteAllDataToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteAllDataToolStripMenuItem.Name = "deleteAllDataToolStripMenuItem";
            this.deleteAllDataToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.deleteAllDataToolStripMenuItem.Text = "Delete &all data";
            this.deleteAllDataToolStripMenuItem.Click += new System.EventHandler(this.deleteAllDataToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFilterAll,
            this.toolStripMenuItemFilterWarnings,
            this.toolStripMenuItemFilterErrors,
            this.toolStripSeparator4,
            this.freezeFirstAndLastNameColumnsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // toolStripMenuItemFilterAll
            // 
            this.toolStripMenuItemFilterAll.Image = global::ESFA.FE.StaffEntry.Properties.Resources.Aggregate_16x;
            this.toolStripMenuItemFilterAll.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItemFilterAll.Name = "toolStripMenuItemFilterAll";
            this.toolStripMenuItemFilterAll.Size = new System.Drawing.Size(256, 22);
            this.toolStripMenuItemFilterAll.Text = "Show &all rows";
            this.toolStripMenuItemFilterAll.Click += new System.EventHandler(this.toolStripMenuItemFilterAll_Click);
            // 
            // toolStripMenuItemFilterWarnings
            // 
            this.toolStripMenuItemFilterWarnings.Image = global::ESFA.FE.StaffEntry.Properties.Resources.AggregateWarning_16x;
            this.toolStripMenuItemFilterWarnings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItemFilterWarnings.Name = "toolStripMenuItemFilterWarnings";
            this.toolStripMenuItemFilterWarnings.Size = new System.Drawing.Size(256, 22);
            this.toolStripMenuItemFilterWarnings.Text = "Show only rows with &warnings";
            this.toolStripMenuItemFilterWarnings.Click += new System.EventHandler(this.toolStripMenuItemFilterWarnings_Click);
            // 
            // toolStripMenuItemFilterErrors
            // 
            this.toolStripMenuItemFilterErrors.Image = global::ESFA.FE.StaffEntry.Properties.Resources.AggregateError_16x;
            this.toolStripMenuItemFilterErrors.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItemFilterErrors.Name = "toolStripMenuItemFilterErrors";
            this.toolStripMenuItemFilterErrors.Size = new System.Drawing.Size(256, 22);
            this.toolStripMenuItemFilterErrors.Text = "Show only rows with &errors";
            this.toolStripMenuItemFilterErrors.Click += new System.EventHandler(this.toolStripMenuItemFilterErrors_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(253, 6);
            // 
            // freezeFirstAndLastNameColumnsToolStripMenuItem
            // 
            this.freezeFirstAndLastNameColumnsToolStripMenuItem.CheckOnClick = true;
            this.freezeFirstAndLastNameColumnsToolStripMenuItem.Image = global::ESFA.FE.StaffEntry.Properties.Resources.TableColumn_16x;
            this.freezeFirstAndLastNameColumnsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.freezeFirstAndLastNameColumnsToolStripMenuItem.Name = "freezeFirstAndLastNameColumnsToolStripMenuItem";
            this.freezeFirstAndLastNameColumnsToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.freezeFirstAndLastNameColumnsToolStripMenuItem.Text = "Freeze first and last name columns";
            this.freezeFirstAndLastNameColumnsToolStripMenuItem.CheckedChanged += new System.EventHandler(this.freezeFirstAndLastNameColumnsToolStripMenuItem_CheckedChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewMaskedTextColumn1
            // 
            this.dataGridViewMaskedTextColumn1.HeaderText = "Date Of Birth";
            this.dataGridViewMaskedTextColumn1.Mask = "00/00/0000";
            this.dataGridViewMaskedTextColumn1.MinimumWidth = 10;
            this.dataGridViewMaskedTextColumn1.Name = "dataGridViewMaskedTextColumn1";
            this.dataGridViewMaskedTextColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "FTE";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Campus ID";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewMaskedTextColumn2
            // 
            this.dataGridViewMaskedTextColumn2.HeaderText = "Annual Salary";
            this.dataGridViewMaskedTextColumn2.Mask = "$999999";
            this.dataGridViewMaskedTextColumn2.MinimumWidth = 10;
            this.dataGridViewMaskedTextColumn2.Name = "dataGridViewMaskedTextColumn2";
            this.dataGridViewMaskedTextColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMaskedTextColumn2.Width = 200;
            // 
            // dataGridViewMaskedTextColumn3
            // 
            this.dataGridViewMaskedTextColumn3.HeaderText = "Hourly Rate";
            this.dataGridViewMaskedTextColumn3.Mask = "$9999.00";
            this.dataGridViewMaskedTextColumn3.MinimumWidth = 10;
            this.dataGridViewMaskedTextColumn3.Name = "dataGridViewMaskedTextColumn3";
            this.dataGridViewMaskedTextColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMaskedTextColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Week Contracted Hours";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 200;
            // 
            // dataGridViewMaskedTextColumn4
            // 
            this.dataGridViewMaskedTextColumn4.HeaderText = "Employment Start Date";
            this.dataGridViewMaskedTextColumn4.Mask = "00/00/0000";
            this.dataGridViewMaskedTextColumn4.MinimumWidth = 10;
            this.dataGridViewMaskedTextColumn4.Name = "dataGridViewMaskedTextColumn4";
            this.dataGridViewMaskedTextColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMaskedTextColumn4.Width = 200;
            // 
            // dataGridViewMaskedTextColumn5
            // 
            this.dataGridViewMaskedTextColumn5.HeaderText = "Employment End Date";
            this.dataGridViewMaskedTextColumn5.Mask = "00/00/0000";
            this.dataGridViewMaskedTextColumn5.MinimumWidth = 10;
            this.dataGridViewMaskedTextColumn5.Name = "dataGridViewMaskedTextColumn5";
            this.dataGridViewMaskedTextColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMaskedTextColumn5.Width = 200;
            // 
            // GridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 709);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Name = "GridView";
            this.Text = "FE staff data desktop application";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.gridContextMenu.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn DateOfBirth;
        private DataGridViewComboBoxColumn Gender;
        private DataGridViewComboBoxColumn Ethnicity;
        private DataGridViewTextBoxColumn CampusID;
        private DataGridViewTextBoxColumn Disability;
        private DataGridViewCheckBoxColumn MostSeniorLeader;
        private DataGridViewTextBoxColumn FTE;
        private DataGridViewComboBoxColumn MainSubjectTaught;
        private DataGridViewComboBoxColumn HighestTaught;
        private DataGridViewComboBoxColumn HighestEnglish;
        private DataGridViewComboBoxColumn HighestMaths;
        private DataGridViewComboBoxColumn HighestTeachingQualification;
        private DataGridViewTextBoxColumn TeacherQualificationStudied;
        private DataGridViewTextBoxColumn TeacherQualificationFunding;
        private DataGridViewTextBoxColumn ProfessionalTeachingStatus;
        private DataGridViewTextBoxColumn IndustryExperienceDuration;
        private DataGridViewTextBoxColumn CurrentIndustryExperience;
        private DataGridViewTextBoxColumn AnnualSalary;
        private DataGridViewTextBoxColumn HourlyRate;
        private DataGridViewTextBoxColumn WeekContractedHours;
        private DataGridViewComboBoxColumn ContractType;
        private DataGridViewTextBoxColumn NumberContracts;
        private DataGridViewTextBoxColumn EmploymentStartDate;
        private DataGridViewTextBoxColumn EmploymentEndDate;
        private DataGridViewTextBoxColumn CurrentPositionDuration;
        private DataGridViewTextBoxColumn FurtherEducationDuration;
        private DataGridViewComboBoxColumn ReasonForLeaving;
        private ContextMenuStrip gridContextMenu;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private DataGridViewComboBoxColumn MessageStaffDataTeacherData_HighestTaught;
        private DataGridViewComboBoxColumn MessageStaffDataTeacherData_HighestEnglish;
        private DataGridViewComboBoxColumn MessageStaffDataTeacherData_HighestMaths;
        private MenuStrip mainMenu;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openWorkforceDataToolStripMenuItem;
        private ToolStripMenuItem saveWorkforceDataToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private SplitContainer splitContainer2;
        private DataGridView grid;
        private TextBox collectionYear;
        private Label label2;
        private TextBox ukprn;
        private Label label1;
        private ToolStripMenuItem deleteStripMenuItem;
        private ToolStripMenuItem exportForUploadToolStripMenuItem;
        private Label ApplicationVersion;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewMaskedTextColumn dataGridViewMaskedTextColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewMaskedTextColumn dataGridViewMaskedTextColumn2;
        private DataGridViewMaskedTextColumn dataGridViewMaskedTextColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewMaskedTextColumn dataGridViewMaskedTextColumn4;
        private DataGridViewMaskedTextColumn dataGridViewMaskedTextColumn5;
        private ToolStripMenuItem dataToolStripMenuItem;
        private ToolStripMenuItem deleteAllDataToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButtonOpenFile;
        private ToolStripButton toolStripButtonSave;
        private ToolStripButton toolStripButtonExport;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButtonDeleteAll;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripButtonCopy;
        private ToolStripButton toolStripButtonPasteItem;
        private ToolStripButton toolStripButtonPasteNewRows;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItemCopy;
        private ToolStripMenuItem pasteItemToolStripMenuPasteItem;
        private ToolStripMenuItem pasteAsnewRowsToolStripMenuPasteAsNewRows;
        private ToolStripButton toolStripButtonDeleteRow;
        private ToolStripMenuItem deleteSelectedRowsToolStripMenuItem;
        private DataGridViewTextBoxColumn MessageStaffData_FirstName;
        private DataGridViewTextBoxColumn MessageStaffData_LastName;
        private DataGridViewMaskedTextColumn MessageStaffData_DateOfBirth;
        private DataGridViewComboBoxColumn MessageStaffData_Gender;
        private DataGridViewComboBoxColumn MessageStaffData_Ethnicity;
        private DataGridViewComboBoxColumn MessageStaffData_Disability;
        private DataGridViewComboBoxColumn MessageStaffData_MainRole;
        private DataGridViewCheckBoxColumn MessageStaffDataRole_Role_1;
        private DataGridViewCheckBoxColumn MessageStaffDataRole_Role_2;
        private DataGridViewCheckBoxColumn MessageStaffDataRole_Role_3;
        private DataGridViewCheckBoxColumn MessageStaffDataRole_Role_4;
        private DataGridViewCheckBoxColumn MessageStaffDataRole_Role_5;
        private DataGridViewComboBoxColumn MessageStaffData_MostSeniorLeader;
        private DataGridViewTextBoxColumn MessageStaffData_FTE;
        private DataGridViewTextBoxColumn MessageStaffData_CampusID;
        private DataGridViewComboBoxColumn MessageStaffDataTeacherData_MainSubjectTaught;
        private DataGridViewComboBoxColumn MessageStaffDataTeacherData_HighestQualificationTaught;
        private DataGridViewComboBoxColumn MessageStaffDataTeacherData_HighestQualificationEnglish;
        private DataGridViewComboBoxColumn MessageStaffDataTeacherData_HighestQualificationMaths;
        private DataGridViewComboBoxColumn MessageStaffDataTeacherData_HighestTeachingQualification;
        private DataGridViewComboBoxColumn MessageStaffDataTeacherData_TeacherQualificationStudied;
        private DataGridViewComboBoxColumn MessageStaffDataTeacherData_TeacherQualificationFunding;
        private DataGridViewComboBoxColumn MessageStaffDataTeacherData_ProfessionalTeachingStatus;
        private DataGridViewComboBoxColumn MessageStaffDataTeacherData_IndustryExperienceDuration;
        private DataGridViewComboBoxColumn MessageStaffDataTeacherData_CurrentIndustryExperience;
        private DataGridViewTextBoxColumn MessageStaffDataMainContract_AnnualSalary;
        private DataGridViewTextBoxColumn MessageStaffDataMainContract_HourlyRate;
        private DataGridViewTextBoxColumn MessageStaffDataMainContract_WeekContractedHours;
        private DataGridViewComboBoxColumn MessageStaffDataMainContract_ContractType;
        private DataGridViewComboBoxColumn MessageStaffData_NumberContracts;
        private DataGridViewMaskedTextColumn MessageStaffData_EmploymentStartDate;
        private DataGridViewMaskedTextColumn MessageStaffData_EmploymentEndDate;
        private DataGridViewComboBoxColumn MessageStaffData_CurrentPositionDuration;
        private DataGridViewComboBoxColumn MessageStaffData_FurtherEducationDuration;
        private DataGridViewComboBoxColumn MessageStaffData_ReasonForLeaving;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton toolStripButtonFilterAll;
        private ToolStripButton toolStripButtonFilterWarnings;
        private ToolStripButton toolStripButtonFilterErrors;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItemFilterAll;
        private ToolStripMenuItem toolStripMenuItemFilterWarnings;
        private ToolStripMenuItem toolStripMenuItemFilterErrors;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem freezeFirstAndLastNameColumnsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton toolStripButtonFreezeColumns;
        private ToolStripMenuItem showErrorsWarningsToolStripMenuItem;
        private ToolStripMenuItem pasteItemToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripSeparator toolStripSeparator7;
    }
}

