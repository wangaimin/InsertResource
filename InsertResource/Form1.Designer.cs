﻿namespace InsertResource
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSelect = new System.Windows.Forms.Button();
            this.tbResource = new System.Windows.Forms.TextBox();
            this.btnSupplierCategory_Resource = new System.Windows.Forms.Button();
            this.btnSystemCategory_Resource = new System.Windows.Forms.Button();
            this.btnBidTool_TenderBidStatusItem_Resource = new System.Windows.Forms.Button();
            this.btnSystemOrganization_Resource = new System.Windows.Forms.Button();
            this.btnSystemArea_Resource = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDBConfig = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(110, 138);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(191, 72);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "选择数据";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // tbResource
            // 
            this.tbResource.Location = new System.Drawing.Point(353, 138);
            this.tbResource.Multiline = true;
            this.tbResource.Name = "tbResource";
            this.tbResource.Size = new System.Drawing.Size(858, 72);
            this.tbResource.TabIndex = 1;
            this.tbResource.Text = "C:\\Users\\admin\\Desktop\\DB翻译\\已翻译\\区域.xlsx";
            // 
            // btnSupplierCategory_Resource
            // 
            this.btnSupplierCategory_Resource.Location = new System.Drawing.Point(338, 301);
            this.btnSupplierCategory_Resource.Name = "btnSupplierCategory_Resource";
            this.btnSupplierCategory_Resource.Size = new System.Drawing.Size(191, 72);
            this.btnSupplierCategory_Resource.TabIndex = 2;
            this.btnSupplierCategory_Resource.Text = "导入分供方分类资源";
            this.btnSupplierCategory_Resource.UseVisualStyleBackColor = true;
            this.btnSupplierCategory_Resource.Click += new System.EventHandler(this.btnSupplierCategory_Resource_Click);
            // 
            // btnSystemCategory_Resource
            // 
            this.btnSystemCategory_Resource.Location = new System.Drawing.Point(110, 301);
            this.btnSystemCategory_Resource.Name = "btnSystemCategory_Resource";
            this.btnSystemCategory_Resource.Size = new System.Drawing.Size(191, 72);
            this.btnSystemCategory_Resource.TabIndex = 3;
            this.btnSystemCategory_Resource.Text = "导入品类资源";
            this.btnSystemCategory_Resource.UseVisualStyleBackColor = true;
            this.btnSystemCategory_Resource.Click += new System.EventHandler(this.btnSystemCategory_Resource_Click);
            // 
            // btnBidTool_TenderBidStatusItem_Resource
            // 
            this.btnBidTool_TenderBidStatusItem_Resource.Location = new System.Drawing.Point(553, 301);
            this.btnBidTool_TenderBidStatusItem_Resource.Name = "btnBidTool_TenderBidStatusItem_Resource";
            this.btnBidTool_TenderBidStatusItem_Resource.Size = new System.Drawing.Size(191, 72);
            this.btnBidTool_TenderBidStatusItem_Resource.TabIndex = 4;
            this.btnBidTool_TenderBidStatusItem_Resource.Text = "导入招标状态资源";
            this.btnBidTool_TenderBidStatusItem_Resource.UseVisualStyleBackColor = true;
            this.btnBidTool_TenderBidStatusItem_Resource.Click += new System.EventHandler(this.btnBidTool_TenderBidStatusItem_Resource_Click);
            // 
            // btnSystemOrganization_Resource
            // 
            this.btnSystemOrganization_Resource.Location = new System.Drawing.Point(774, 301);
            this.btnSystemOrganization_Resource.Name = "btnSystemOrganization_Resource";
            this.btnSystemOrganization_Resource.Size = new System.Drawing.Size(191, 72);
            this.btnSystemOrganization_Resource.TabIndex = 5;
            this.btnSystemOrganization_Resource.Text = "导入组织资源";
            this.btnSystemOrganization_Resource.UseVisualStyleBackColor = true;
            this.btnSystemOrganization_Resource.Click += new System.EventHandler(this.btnSystemOrganization_Resource_Click);
            // 
            // btnSystemArea_Resource
            // 
            this.btnSystemArea_Resource.Location = new System.Drawing.Point(994, 301);
            this.btnSystemArea_Resource.Name = "btnSystemArea_Resource";
            this.btnSystemArea_Resource.Size = new System.Drawing.Size(191, 72);
            this.btnSystemArea_Resource.TabIndex = 6;
            this.btnSystemArea_Resource.Text = "导入区域资源";
            this.btnSystemArea_Resource.UseVisualStyleBackColor = true;
            this.btnSystemArea_Resource.Click += new System.EventHandler(this.btnSystemArea_Resource_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(106, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 30);
            this.label2.TabIndex = 22;
            this.label2.Text = "数据库地址：";
            // 
            // tbDBConfig
            // 
            this.tbDBConfig.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbDBConfig.Location = new System.Drawing.Point(353, 28);
            this.tbDBConfig.Name = "tbDBConfig";
            this.tbDBConfig.Size = new System.Drawing.Size(858, 42);
            this.tbDBConfig.TabIndex = 21;
            this.tbDBConfig.Text = " data source=localhost;database=YZ_Operation\r\n;user id=sa;password=yzw@123;Timeou" +
    "t=30;";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 543);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDBConfig);
            this.Controls.Add(this.btnSystemArea_Resource);
            this.Controls.Add(this.btnSystemOrganization_Resource);
            this.Controls.Add(this.btnBidTool_TenderBidStatusItem_Resource);
            this.Controls.Add(this.btnSystemCategory_Resource);
            this.Controls.Add(this.btnSupplierCategory_Resource);
            this.Controls.Add(this.tbResource);
            this.Controls.Add(this.btnSelect);
            this.Name = "Form1";
            this.Text = "写入资源表";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox tbResource;
        private System.Windows.Forms.Button btnSupplierCategory_Resource;
        private System.Windows.Forms.Button btnSystemCategory_Resource;
        private System.Windows.Forms.Button btnBidTool_TenderBidStatusItem_Resource;
        private System.Windows.Forms.Button btnSystemOrganization_Resource;
        private System.Windows.Forms.Button btnSystemArea_Resource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDBConfig;
    }
}

