﻿namespace Book_Management
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.picBook = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.MaskedTextBox();
            this.txtSummary = new System.Windows.Forms.TextBox();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.gvBookView = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnImageAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtISBN = new System.Windows.Forms.MaskedTextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnXml = new System.Windows.Forms.Button();
            this.btnEditImage = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.imageDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnConfirmNaver = new System.Windows.Forms.Button();
            this.txtSearchNaver = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.picBookNaver = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtDescriptionNaver = new System.Windows.Forms.TextBox();
            this.txtIsbnNaver = new System.Windows.Forms.TextBox();
            this.txtPubdateNaver = new System.Windows.Forms.TextBox();
            this.txtPublisherNaver = new System.Windows.Forms.TextBox();
            this.txtDiscountNaver = new System.Windows.Forms.TextBox();
            this.txtPriceNaver = new System.Windows.Forms.TextBox();
            this.txtAuthorNaver = new System.Windows.Forms.TextBox();
            this.txtNameNaver = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gvBookViewNaver = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.picBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBookView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBookNaver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBookViewNaver)).BeginInit();
            this.SuspendLayout();
            // 
            // picBook
            // 
            this.picBook.Location = new System.Drawing.Point(19, 25);
            this.picBook.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picBook.Name = "picBook";
            this.picBook.Size = new System.Drawing.Size(210, 341);
            this.picBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBook.TabIndex = 0;
            this.picBook.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(256, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "ISBN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(256, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "책이름";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(256, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "저자";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(256, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "가격";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(256, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "내용요약";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(256, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "분류(카테고리)";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(325, 76);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(239, 25);
            this.txtName.TabIndex = 7;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(325, 132);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(239, 25);
            this.txtAuthor.TabIndex = 8;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(325, 189);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrice.Mask = "00,000원";
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(239, 25);
            this.txtPrice.TabIndex = 9;
            // 
            // txtSummary
            // 
            this.txtSummary.Location = new System.Drawing.Point(343, 245);
            this.txtSummary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSummary.Name = "txtSummary";
            this.txtSummary.Size = new System.Drawing.Size(363, 25);
            this.txtSummary.TabIndex = 10;
            // 
            // cboCategory
            // 
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Items.AddRange(new object[] {
            "소설",
            "시/에세이",
            "경제/경영",
            "자기계발",
            "인문",
            "역사/문화",
            "사회",
            "과학/공학",
            "예술/대중문화",
            "종교",
            "유아",
            "어린이",
            "가정/생활/요리",
            "건강",
            "취미/레저",
            "여행/지도",
            "국어/외국어",
            "사전",
            "컴퓨터/IT",
            "청소년",
            "학습/참고서",
            "취업/수험서",
            "만화",
            "잡지",
            "해외도서"});
            this.cboCategory.Location = new System.Drawing.Point(389, 345);
            this.cboCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(145, 23);
            this.cboCategory.TabIndex = 11;
            // 
            // gvBookView
            // 
            this.gvBookView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvBookView.Location = new System.Drawing.Point(5, 411);
            this.gvBookView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gvBookView.Name = "gvBookView";
            this.gvBookView.RowTemplate.Height = 23;
            this.gvBookView.Size = new System.Drawing.Size(1086, 250);
            this.gvBookView.TabIndex = 13;
            this.gvBookView.Click += new System.EventHandler(this.gvBookView_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAdd.Location = new System.Drawing.Point(10, 96);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(145, 65);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "저장";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(256, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "이미지";
            // 
            // btnImageAdd
            // 
            this.btnImageAdd.Location = new System.Drawing.Point(343, 298);
            this.btnImageAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnImageAdd.Name = "btnImageAdd";
            this.btnImageAdd.Size = new System.Drawing.Size(104, 29);
            this.btnImageAdd.TabIndex = 19;
            this.btnImageAdd.Text = "이미지 선택";
            this.btnImageAdd.UseVisualStyleBackColor = true;
            this.btnImageAdd.Click += new System.EventHandler(this.btnImageAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtISBN);
            this.groupBox1.Controls.Add(this.btnImageAdd);
            this.groupBox1.Controls.Add(this.picBook);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboCategory);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSummary);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtAuthor);
            this.groupBox1.Location = new System.Drawing.Point(6, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(739, 389);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(325, 24);
            this.txtISBN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtISBN.Mask = "0000000000000";
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(106, 25);
            this.txtISBN.TabIndex = 20;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnEdit.Location = new System.Drawing.Point(171, 166);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(145, 65);
            this.btnEdit.TabIndex = 21;
            this.btnEdit.Text = "이미지 제외 수정";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDelete.Location = new System.Drawing.Point(10, 168);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(145, 64);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearch.Location = new System.Drawing.Point(7, 71);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(281, 46);
            this.btnSearch.TabIndex = 23;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnXml);
            this.groupBox2.Controls.Add(this.btnEditImage);
            this.groupBox2.Controls.Add(this.btnReset);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Location = new System.Drawing.Point(767, 7);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(323, 389);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // btnXml
            // 
            this.btnXml.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnXml.Location = new System.Drawing.Point(171, 25);
            this.btnXml.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXml.Name = "btnXml";
            this.btnXml.Size = new System.Drawing.Size(145, 65);
            this.btnXml.TabIndex = 27;
            this.btnXml.Text = "Xml 생성";
            this.btnXml.UseVisualStyleBackColor = true;
            this.btnXml.Click += new System.EventHandler(this.btnXml_Click);
            // 
            // btnEditImage
            // 
            this.btnEditImage.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnEditImage.Location = new System.Drawing.Point(171, 96);
            this.btnEditImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditImage.Name = "btnEditImage";
            this.btnEditImage.Size = new System.Drawing.Size(145, 62);
            this.btnEditImage.TabIndex = 26;
            this.btnEditImage.Text = "이미지 수정";
            this.btnEditImage.UseVisualStyleBackColor = true;
            this.btnEditImage.Click += new System.EventHandler(this.btnEditImage_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnReset.Location = new System.Drawing.Point(10, 25);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(145, 65);
            this.btnReset.TabIndex = 25;
            this.btnReset.Text = "새로 만들기";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSearch);
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Location = new System.Drawing.Point(10, 241);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(295, 125);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "책 이름 검색";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(7, 25);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(281, 25);
            this.txtSearch.TabIndex = 24;
            // 
            // imageDialog
            // 
            this.imageDialog.FileName = "openFileDialog1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1108, 697);
            this.tabControl1.TabIndex = 25;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.gvBookView);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1100, 668);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "책 추가";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.picBookNaver);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.txtDescriptionNaver);
            this.tabPage2.Controls.Add(this.txtIsbnNaver);
            this.tabPage2.Controls.Add(this.txtPubdateNaver);
            this.tabPage2.Controls.Add(this.txtPublisherNaver);
            this.tabPage2.Controls.Add(this.txtDiscountNaver);
            this.tabPage2.Controls.Add(this.txtPriceNaver);
            this.tabPage2.Controls.Add(this.txtAuthorNaver);
            this.tabPage2.Controls.Add(this.txtNameNaver);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.gvBookViewNaver);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1100, 668);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "네이버 책 검색";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnConfirmNaver);
            this.groupBox4.Controls.Add(this.txtSearchNaver);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(23, 9);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1057, 59);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "검색";
            // 
            // btnConfirmNaver
            // 
            this.btnConfirmNaver.Location = new System.Drawing.Point(347, 23);
            this.btnConfirmNaver.Name = "btnConfirmNaver";
            this.btnConfirmNaver.Size = new System.Drawing.Size(93, 25);
            this.btnConfirmNaver.TabIndex = 3;
            this.btnConfirmNaver.Text = "검색";
            this.btnConfirmNaver.UseVisualStyleBackColor = true;
            this.btnConfirmNaver.Click += new System.EventHandler(this.btnConfirmNaver_Click);
            // 
            // txtSearchNaver
            // 
            this.txtSearchNaver.Location = new System.Drawing.Point(77, 24);
            this.txtSearchNaver.Name = "txtSearchNaver";
            this.txtSearchNaver.Size = new System.Drawing.Size(258, 25);
            this.txtSearchNaver.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(12, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "검색어";
            // 
            // picBookNaver
            // 
            this.picBookNaver.Location = new System.Drawing.Point(896, 92);
            this.picBookNaver.Name = "picBookNaver";
            this.picBookNaver.Size = new System.Drawing.Size(152, 169);
            this.picBookNaver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBookNaver.TabIndex = 22;
            this.picBookNaver.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label17.Location = new System.Drawing.Point(831, 88);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 23);
            this.label17.TabIndex = 21;
            this.label17.Text = "사진:";
            // 
            // txtDescriptionNaver
            // 
            this.txtDescriptionNaver.Location = new System.Drawing.Point(532, 134);
            this.txtDescriptionNaver.Multiline = true;
            this.txtDescriptionNaver.Name = "txtDescriptionNaver";
            this.txtDescriptionNaver.ReadOnly = true;
            this.txtDescriptionNaver.Size = new System.Drawing.Size(284, 211);
            this.txtDescriptionNaver.TabIndex = 20;
            // 
            // txtIsbnNaver
            // 
            this.txtIsbnNaver.Location = new System.Drawing.Point(532, 88);
            this.txtIsbnNaver.Name = "txtIsbnNaver";
            this.txtIsbnNaver.ReadOnly = true;
            this.txtIsbnNaver.Size = new System.Drawing.Size(204, 25);
            this.txtIsbnNaver.TabIndex = 19;
            // 
            // txtPubdateNaver
            // 
            this.txtPubdateNaver.Location = new System.Drawing.Point(117, 320);
            this.txtPubdateNaver.Name = "txtPubdateNaver";
            this.txtPubdateNaver.ReadOnly = true;
            this.txtPubdateNaver.Size = new System.Drawing.Size(138, 25);
            this.txtPubdateNaver.TabIndex = 18;
            // 
            // txtPublisherNaver
            // 
            this.txtPublisherNaver.Location = new System.Drawing.Point(117, 276);
            this.txtPublisherNaver.Name = "txtPublisherNaver";
            this.txtPublisherNaver.ReadOnly = true;
            this.txtPublisherNaver.Size = new System.Drawing.Size(138, 25);
            this.txtPublisherNaver.TabIndex = 17;
            // 
            // txtDiscountNaver
            // 
            this.txtDiscountNaver.Location = new System.Drawing.Point(133, 229);
            this.txtDiscountNaver.Name = "txtDiscountNaver";
            this.txtDiscountNaver.ReadOnly = true;
            this.txtDiscountNaver.Size = new System.Drawing.Size(138, 25);
            this.txtDiscountNaver.TabIndex = 16;
            // 
            // txtPriceNaver
            // 
            this.txtPriceNaver.Location = new System.Drawing.Point(97, 182);
            this.txtPriceNaver.Name = "txtPriceNaver";
            this.txtPriceNaver.ReadOnly = true;
            this.txtPriceNaver.Size = new System.Drawing.Size(138, 25);
            this.txtPriceNaver.TabIndex = 15;
            // 
            // txtAuthorNaver
            // 
            this.txtAuthorNaver.Location = new System.Drawing.Point(97, 135);
            this.txtAuthorNaver.Name = "txtAuthorNaver";
            this.txtAuthorNaver.ReadOnly = true;
            this.txtAuthorNaver.Size = new System.Drawing.Size(254, 25);
            this.txtAuthorNaver.TabIndex = 14;
            // 
            // txtNameNaver
            // 
            this.txtNameNaver.Location = new System.Drawing.Point(97, 88);
            this.txtNameNaver.Name = "txtNameNaver";
            this.txtNameNaver.ReadOnly = true;
            this.txtNameNaver.Size = new System.Drawing.Size(336, 25);
            this.txtNameNaver.TabIndex = 13;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.Location = new System.Drawing.Point(467, 131);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 23);
            this.label16.TabIndex = 12;
            this.label16.Text = "요약:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.Location = new System.Drawing.Point(467, 85);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 23);
            this.label15.TabIndex = 11;
            this.label15.Text = "ISBN:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.Location = new System.Drawing.Point(35, 320);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 23);
            this.label14.TabIndex = 10;
            this.label14.Text = "출판일: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(35, 273);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 23);
            this.label13.TabIndex = 9;
            this.label13.Text = "출판사:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(35, 226);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 23);
            this.label12.TabIndex = 8;
            this.label12.Text = "할인가격:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(35, 179);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 23);
            this.label11.TabIndex = 7;
            this.label11.Text = "가격:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(35, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 23);
            this.label10.TabIndex = 6;
            this.label10.Text = "저자:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(35, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 23);
            this.label9.TabIndex = 5;
            this.label9.Text = "이름:";
            // 
            // gvBookViewNaver
            // 
            this.gvBookViewNaver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvBookViewNaver.Location = new System.Drawing.Point(23, 392);
            this.gvBookViewNaver.Name = "gvBookViewNaver";
            this.gvBookViewNaver.RowTemplate.Height = 27;
            this.gvBookViewNaver.Size = new System.Drawing.Size(1057, 255);
            this.gvBookViewNaver.TabIndex = 4;
            this.gvBookViewNaver.Click += new System.EventHandler(this.gvBookViewNaver_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 717);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "도서관리 프로그램";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBookView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBookNaver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBookViewNaver)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.MaskedTextBox txtPrice;
        private System.Windows.Forms.TextBox txtSummary;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.DataGridView gvBookView;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnImageAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.OpenFileDialog imageDialog;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnEditImage;
        private System.Windows.Forms.MaskedTextBox txtISBN;
        private System.Windows.Forms.Button btnXml;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnConfirmNaver;
        private System.Windows.Forms.TextBox txtSearchNaver;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView gvBookViewNaver;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtDescriptionNaver;
        private System.Windows.Forms.TextBox txtIsbnNaver;
        private System.Windows.Forms.TextBox txtPubdateNaver;
        private System.Windows.Forms.TextBox txtPublisherNaver;
        private System.Windows.Forms.TextBox txtDiscountNaver;
        private System.Windows.Forms.TextBox txtPriceNaver;
        private System.Windows.Forms.TextBox txtAuthorNaver;
        private System.Windows.Forms.TextBox txtNameNaver;
        private System.Windows.Forms.PictureBox picBookNaver;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

