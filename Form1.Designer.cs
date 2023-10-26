namespace EmployeeDBApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btn_load = new Button();
            dataGridView1 = new DataGridView();
            btn_search = new Button();
            tb_search = new TextBox();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            btn_add = new Button();
            txt_Adddisc = new TextBox();
            txt_AddIMGURL = new TextBox();
            txt_AddNumEm = new TextBox();
            txt_AddTitle = new TextBox();
            label_description = new Label();
            label_imgUrl = new Label();
            label_title = new Label();
            label_numEmp = new Label();
            dataGridView2 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btn_load
            // 
            resources.ApplyResources(btn_load, "btn_load");
            btn_load.Name = "btn_load";
            btn_load.UseVisualStyleBackColor = true;
            btn_load.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(dataGridView1, "dataGridView1");
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btn_search
            // 
            resources.ApplyResources(btn_search, "btn_search");
            btn_search.Name = "btn_search";
            btn_search.UseVisualStyleBackColor = true;
            btn_search.Click += btn_search_Click;
            // 
            // tb_search
            // 
            resources.ApplyResources(tb_search, "tb_search");
            tb_search.Name = "tb_search";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_add);
            groupBox1.Controls.Add(txt_Adddisc);
            groupBox1.Controls.Add(txt_AddIMGURL);
            groupBox1.Controls.Add(txt_AddNumEm);
            groupBox1.Controls.Add(txt_AddTitle);
            groupBox1.Controls.Add(label_description);
            groupBox1.Controls.Add(label_imgUrl);
            groupBox1.Controls.Add(label_title);
            groupBox1.Controls.Add(label_numEmp);
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // btn_add
            // 
            resources.ApplyResources(btn_add, "btn_add");
            btn_add.Name = "btn_add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // txt_Adddisc
            // 
            resources.ApplyResources(txt_Adddisc, "txt_Adddisc");
            txt_Adddisc.Name = "txt_Adddisc";
            // 
            // txt_AddIMGURL
            // 
            resources.ApplyResources(txt_AddIMGURL, "txt_AddIMGURL");
            txt_AddIMGURL.Name = "txt_AddIMGURL";
            // 
            // txt_AddNumEm
            // 
            resources.ApplyResources(txt_AddNumEm, "txt_AddNumEm");
            txt_AddNumEm.Name = "txt_AddNumEm";
            // 
            // txt_AddTitle
            // 
            resources.ApplyResources(txt_AddTitle, "txt_AddTitle");
            txt_AddTitle.Name = "txt_AddTitle";
            // 
            // label_description
            // 
            resources.ApplyResources(label_description, "label_description");
            label_description.Name = "label_description";
            // 
            // label_imgUrl
            // 
            resources.ApplyResources(label_imgUrl, "label_imgUrl");
            label_imgUrl.Name = "label_imgUrl";
            // 
            // label_title
            // 
            resources.ApplyResources(label_title, "label_title");
            label_title.Name = "label_title";
            // 
            // label_numEmp
            // 
            resources.ApplyResources(label_numEmp, "label_numEmp");
            label_numEmp.Name = "label_numEmp";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(dataGridView2, "dataGridView2");
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // pictureBox2
            // 
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView2);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(tb_search);
            Controls.Add(btn_search);
            Controls.Add(dataGridView1);
            Controls.Add(btn_load);
            Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_load;
        private DataGridView dataGridView1;
        private Button btn_search;
        private TextBox tb_search;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private TextBox txt_AddTitle;
        private Label label_description;
        private Label label_imgUrl;
        private Label label_title;
        private Label label_numEmp;
        private TextBox txt_Adddisc;
        private TextBox txt_AddIMGURL;
        private TextBox txt_AddNumEm;
        private Button btn_add;
        private DataGridView dataGridView2;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox2;
    }
}