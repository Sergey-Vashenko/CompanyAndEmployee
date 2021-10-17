
namespace Lift_Complex_Test
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.getCompanyTable = new System.Windows.Forms.Button();
            this.getEmploeeTable = new System.Windows.Forms.Button();
            this.setDataTable = new System.Windows.Forms.Button();
            this.buttSearch = new System.Windows.Forms.Button();
            this.labelSalary = new System.Windows.Forms.Label();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.labelPosition = new System.Windows.Forms.Label();
            this.textBoxPosition = new System.Windows.Forms.TextBox();
            this.labelIdCompany = new System.Windows.Forms.Label();
            this.textBoxIdCompany = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.buttInsert1000Records = new System.Windows.Forms.Button();
            this.groupBoxSearchEmployee = new System.Windows.Forms.GroupBox();
            this.groupBoxDataView = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBoxSearchEmployee.SuspendLayout();
            this.groupBoxDataView.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(6, 26);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 29;
            this.dataGridView.Size = new System.Drawing.Size(704, 311);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseClick);
            // 
            // getCompanyTable
            // 
            this.getCompanyTable.Location = new System.Drawing.Point(71, 355);
            this.getCompanyTable.Name = "getCompanyTable";
            this.getCompanyTable.Size = new System.Drawing.Size(136, 52);
            this.getCompanyTable.TabIndex = 1;
            this.getCompanyTable.Tag = "Company";
            this.getCompanyTable.Text = "Открыть таблицу \"Компании\"";
            this.getCompanyTable.UseVisualStyleBackColor = true;
            this.getCompanyTable.Click += new System.EventHandler(this.getTable);
            // 
            // getEmploeeTable
            // 
            this.getEmploeeTable.Location = new System.Drawing.Point(281, 355);
            this.getEmploeeTable.Name = "getEmploeeTable";
            this.getEmploeeTable.Size = new System.Drawing.Size(136, 52);
            this.getEmploeeTable.TabIndex = 2;
            this.getEmploeeTable.Tag = "Employee";
            this.getEmploeeTable.Text = "Открыть таблицу \"Сотрудники\"";
            this.getEmploeeTable.UseVisualStyleBackColor = true;
            this.getEmploeeTable.Click += new System.EventHandler(this.getTable);
            // 
            // setDataTable
            // 
            this.setDataTable.Location = new System.Drawing.Point(509, 355);
            this.setDataTable.Name = "setDataTable";
            this.setDataTable.Size = new System.Drawing.Size(129, 52);
            this.setDataTable.TabIndex = 3;
            this.setDataTable.Text = "Сохранить изменения";
            this.setDataTable.UseVisualStyleBackColor = true;
            this.setDataTable.Click += new System.EventHandler(this.setDataTable_Click);
            // 
            // buttSearch
            // 
            this.buttSearch.Location = new System.Drawing.Point(117, 279);
            this.buttSearch.Name = "buttSearch";
            this.buttSearch.Size = new System.Drawing.Size(119, 43);
            this.buttSearch.TabIndex = 12;
            this.buttSearch.Text = "Найти";
            this.buttSearch.UseVisualStyleBackColor = true;
            this.buttSearch.Click += new System.EventHandler(this.buttSearch_Click);
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Location = new System.Drawing.Point(209, 200);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(117, 20);
            this.labelSalary.TabIndex = 11;
            this.labelSalary.Text = "salary employee";
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Location = new System.Drawing.Point(209, 223);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(125, 27);
            this.textBoxSalary.TabIndex = 10;
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(23, 200);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(133, 20);
            this.labelPosition.TabIndex = 9;
            this.labelPosition.Text = "position employee";
            // 
            // textBoxPosition
            // 
            this.textBoxPosition.Location = new System.Drawing.Point(23, 223);
            this.textBoxPosition.Name = "textBoxPosition";
            this.textBoxPosition.Size = new System.Drawing.Size(125, 27);
            this.textBoxPosition.TabIndex = 8;
            // 
            // labelIdCompany
            // 
            this.labelIdCompany.AutoSize = true;
            this.labelIdCompany.Location = new System.Drawing.Point(209, 33);
            this.labelIdCompany.Name = "labelIdCompany";
            this.labelIdCompany.Size = new System.Drawing.Size(155, 20);
            this.labelIdCompany.TabIndex = 7;
            this.labelIdCompany.Text = "idCompany employee";
            // 
            // textBoxIdCompany
            // 
            this.textBoxIdCompany.Location = new System.Drawing.Point(209, 56);
            this.textBoxIdCompany.Name = "textBoxIdCompany";
            this.textBoxIdCompany.Size = new System.Drawing.Size(125, 27);
            this.textBoxIdCompany.TabIndex = 6;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(209, 141);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(137, 27);
            this.textBoxSurname.TabIndex = 5;
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(209, 118);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(137, 20);
            this.labelSurname.TabIndex = 4;
            this.labelSurname.Text = "Surname employee";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(23, 141);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(125, 27);
            this.textBoxName.TabIndex = 3;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(23, 118);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(119, 20);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name employee";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(23, 33);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(92, 20);
            this.labelId.TabIndex = 1;
            this.labelId.Text = "id employee";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(23, 56);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(125, 27);
            this.textBoxId.TabIndex = 0;
            // 
            // buttInsert1000Records
            // 
            this.buttInsert1000Records.Location = new System.Drawing.Point(745, 367);
            this.buttInsert1000Records.Name = "buttInsert1000Records";
            this.buttInsert1000Records.Size = new System.Drawing.Size(178, 72);
            this.buttInsert1000Records.TabIndex = 6;
            this.buttInsert1000Records.Text = "Создать 10 компаний с 100 сотрудниками в каждой";
            this.buttInsert1000Records.UseVisualStyleBackColor = true;
            this.buttInsert1000Records.Click += new System.EventHandler(this.buttInsert1000Records_Click);
            // 
            // groupBoxSearchEmployee
            // 
            this.groupBoxSearchEmployee.Controls.Add(this.buttSearch);
            this.groupBoxSearchEmployee.Controls.Add(this.labelSalary);
            this.groupBoxSearchEmployee.Controls.Add(this.textBoxId);
            this.groupBoxSearchEmployee.Controls.Add(this.textBoxSalary);
            this.groupBoxSearchEmployee.Controls.Add(this.labelId);
            this.groupBoxSearchEmployee.Controls.Add(this.labelPosition);
            this.groupBoxSearchEmployee.Controls.Add(this.labelName);
            this.groupBoxSearchEmployee.Controls.Add(this.textBoxPosition);
            this.groupBoxSearchEmployee.Controls.Add(this.textBoxName);
            this.groupBoxSearchEmployee.Controls.Add(this.labelIdCompany);
            this.groupBoxSearchEmployee.Controls.Add(this.labelSurname);
            this.groupBoxSearchEmployee.Controls.Add(this.textBoxIdCompany);
            this.groupBoxSearchEmployee.Controls.Add(this.textBoxSurname);
            this.groupBoxSearchEmployee.Location = new System.Drawing.Point(745, 12);
            this.groupBoxSearchEmployee.Name = "groupBoxSearchEmployee";
            this.groupBoxSearchEmployee.Size = new System.Drawing.Size(384, 339);
            this.groupBoxSearchEmployee.TabIndex = 7;
            this.groupBoxSearchEmployee.TabStop = false;
            this.groupBoxSearchEmployee.Text = "Поиск сотрудника";
            // 
            // groupBoxDataView
            // 
            this.groupBoxDataView.Controls.Add(this.dataGridView);
            this.groupBoxDataView.Controls.Add(this.setDataTable);
            this.groupBoxDataView.Controls.Add(this.getCompanyTable);
            this.groupBoxDataView.Controls.Add(this.getEmploeeTable);
            this.groupBoxDataView.Location = new System.Drawing.Point(6, 12);
            this.groupBoxDataView.Name = "groupBoxDataView";
            this.groupBoxDataView.Size = new System.Drawing.Size(721, 427);
            this.groupBoxDataView.TabIndex = 8;
            this.groupBoxDataView.TabStop = false;
            this.groupBoxDataView.Text = "Словарь организаций и персонала";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 449);
            this.Controls.Add(this.groupBoxDataView);
            this.Controls.Add(this.groupBoxSearchEmployee);
            this.Controls.Add(this.buttInsert1000Records);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBoxSearchEmployee.ResumeLayout(false);
            this.groupBoxSearchEmployee.PerformLayout();
            this.groupBoxDataView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button getCompanyTable;
        private System.Windows.Forms.Button getEmploeeTable;
        private System.Windows.Forms.Button setDataTable;
        private System.Windows.Forms.Button buttSearch;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.TextBox textBoxPosition;
        private System.Windows.Forms.Label labelIdCompany;
        private System.Windows.Forms.TextBox textBoxIdCompany;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Button buttInsert1000Records;
        private System.Windows.Forms.GroupBox groupBoxSearchEmployee;
        private System.Windows.Forms.GroupBox groupBoxDataView;
    }
}

