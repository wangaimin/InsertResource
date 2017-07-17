namespace InsertResource
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
            this.t = new System.Windows.Forms.Label();
            this.btnSystemTagRole = new System.Windows.Forms.Button();
            this.btnSystemTagRoleForQA = new System.Windows.Forms.Button();
            this.btnSystemMenu_Resource = new System.Windows.Forms.Button();
            this.btnSystemMenu_ResourceQA = new System.Windows.Forms.Button();
            this.btnAuditNode_Resource = new System.Windows.Forms.Button();
            this.btnAuditNode_ResourceQA = new System.Windows.Forms.Button();
            this.btnSystemCategoryByName = new System.Windows.Forms.Button();
            this.btnSupplierCategory_ResourceByName = new System.Windows.Forms.Button();
            this.tbWriteDB = new System.Windows.Forms.TextBox();
            this.btnSystemFunction = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbReadDB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(83, 213);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(191, 72);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "选择数据";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // tbResource
            // 
            this.tbResource.Location = new System.Drawing.Point(326, 213);
            this.tbResource.Multiline = true;
            this.tbResource.Name = "tbResource";
            this.tbResource.Size = new System.Drawing.Size(858, 72);
            this.tbResource.TabIndex = 1;
            this.tbResource.Text = "C:\\Users\\admin\\Desktop\\DB翻译\\已翻译\\区域.xlsx";
            // 
            // btnSupplierCategory_Resource
            // 
            this.btnSupplierCategory_Resource.Location = new System.Drawing.Point(311, 376);
            this.btnSupplierCategory_Resource.Name = "btnSupplierCategory_Resource";
            this.btnSupplierCategory_Resource.Size = new System.Drawing.Size(191, 72);
            this.btnSupplierCategory_Resource.TabIndex = 2;
            this.btnSupplierCategory_Resource.Text = "导入分供方分类资源";
            this.btnSupplierCategory_Resource.UseVisualStyleBackColor = true;
            this.btnSupplierCategory_Resource.Click += new System.EventHandler(this.btnSupplierCategory_Resource_Click);
            // 
            // btnSystemCategory_Resource
            // 
            this.btnSystemCategory_Resource.Location = new System.Drawing.Point(83, 376);
            this.btnSystemCategory_Resource.Name = "btnSystemCategory_Resource";
            this.btnSystemCategory_Resource.Size = new System.Drawing.Size(191, 72);
            this.btnSystemCategory_Resource.TabIndex = 3;
            this.btnSystemCategory_Resource.Text = "导入品类资源";
            this.btnSystemCategory_Resource.UseVisualStyleBackColor = true;
            this.btnSystemCategory_Resource.Click += new System.EventHandler(this.btnSystemCategory_Resource_Click);
            // 
            // btnBidTool_TenderBidStatusItem_Resource
            // 
            this.btnBidTool_TenderBidStatusItem_Resource.Location = new System.Drawing.Point(526, 376);
            this.btnBidTool_TenderBidStatusItem_Resource.Name = "btnBidTool_TenderBidStatusItem_Resource";
            this.btnBidTool_TenderBidStatusItem_Resource.Size = new System.Drawing.Size(191, 72);
            this.btnBidTool_TenderBidStatusItem_Resource.TabIndex = 4;
            this.btnBidTool_TenderBidStatusItem_Resource.Text = "导入招标状态资源";
            this.btnBidTool_TenderBidStatusItem_Resource.UseVisualStyleBackColor = true;
            this.btnBidTool_TenderBidStatusItem_Resource.Click += new System.EventHandler(this.btnBidTool_TenderBidStatusItem_Resource_Click);
            // 
            // btnSystemOrganization_Resource
            // 
            this.btnSystemOrganization_Resource.Location = new System.Drawing.Point(747, 376);
            this.btnSystemOrganization_Resource.Name = "btnSystemOrganization_Resource";
            this.btnSystemOrganization_Resource.Size = new System.Drawing.Size(191, 72);
            this.btnSystemOrganization_Resource.TabIndex = 5;
            this.btnSystemOrganization_Resource.Text = "导入组织资源";
            this.btnSystemOrganization_Resource.UseVisualStyleBackColor = true;
            this.btnSystemOrganization_Resource.Click += new System.EventHandler(this.btnSystemOrganization_Resource_Click);
            // 
            // btnSystemArea_Resource
            // 
            this.btnSystemArea_Resource.Location = new System.Drawing.Point(967, 376);
            this.btnSystemArea_Resource.Name = "btnSystemArea_Resource";
            this.btnSystemArea_Resource.Size = new System.Drawing.Size(191, 72);
            this.btnSystemArea_Resource.TabIndex = 6;
            this.btnSystemArea_Resource.Text = "导入区域资源";
            this.btnSystemArea_Resource.UseVisualStyleBackColor = true;
            this.btnSystemArea_Resource.Click += new System.EventHandler(this.btnSystemArea_Resource_Click);
            // 
            // t
            // 
            this.t.AutoSize = true;
            this.t.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.t.Location = new System.Drawing.Point(79, 115);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(148, 30);
            this.t.TabIndex = 22;
            this.t.Text = "WriteDB：";
            // 
            // btnSystemTagRole
            // 
            this.btnSystemTagRole.Location = new System.Drawing.Point(81, 607);
            this.btnSystemTagRole.Name = "btnSystemTagRole";
            this.btnSystemTagRole.Size = new System.Drawing.Size(191, 72);
            this.btnSystemTagRole.TabIndex = 23;
            this.btnSystemTagRole.Text = "导入角色类型资源";
            this.btnSystemTagRole.UseVisualStyleBackColor = true;
            this.btnSystemTagRole.Click += new System.EventHandler(this.btSystemTagRole_Click);
            // 
            // btnSystemTagRoleForQA
            // 
            this.btnSystemTagRoleForQA.Location = new System.Drawing.Point(81, 710);
            this.btnSystemTagRoleForQA.Name = "btnSystemTagRoleForQA";
            this.btnSystemTagRoleForQA.Size = new System.Drawing.Size(191, 72);
            this.btnSystemTagRoleForQA.TabIndex = 24;
            this.btnSystemTagRoleForQA.Text = "更新角色类型资源(QA,PRE)";
            this.btnSystemTagRoleForQA.UseVisualStyleBackColor = true;
            this.btnSystemTagRoleForQA.Click += new System.EventHandler(this.btSystemTagRoleForQA_Click);
            // 
            // btnSystemMenu_Resource
            // 
            this.btnSystemMenu_Resource.Location = new System.Drawing.Point(297, 607);
            this.btnSystemMenu_Resource.Name = "btnSystemMenu_Resource";
            this.btnSystemMenu_Resource.Size = new System.Drawing.Size(191, 72);
            this.btnSystemMenu_Resource.TabIndex = 25;
            this.btnSystemMenu_Resource.Text = "导入菜单资源";
            this.btnSystemMenu_Resource.UseVisualStyleBackColor = true;
            this.btnSystemMenu_Resource.Click += new System.EventHandler(this.btnSystemMenu_Resource_Click);
            // 
            // btnSystemMenu_ResourceQA
            // 
            this.btnSystemMenu_ResourceQA.Location = new System.Drawing.Point(297, 710);
            this.btnSystemMenu_ResourceQA.Name = "btnSystemMenu_ResourceQA";
            this.btnSystemMenu_ResourceQA.Size = new System.Drawing.Size(191, 72);
            this.btnSystemMenu_ResourceQA.TabIndex = 26;
            this.btnSystemMenu_ResourceQA.Text = "更新菜单资源（QA,PRE）";
            this.btnSystemMenu_ResourceQA.UseVisualStyleBackColor = true;
            this.btnSystemMenu_ResourceQA.Click += new System.EventHandler(this.btnSystemMenu_ResourceQA_Click);
            // 
            // btnAuditNode_Resource
            // 
            this.btnAuditNode_Resource.Location = new System.Drawing.Point(526, 607);
            this.btnAuditNode_Resource.Name = "btnAuditNode_Resource";
            this.btnAuditNode_Resource.Size = new System.Drawing.Size(191, 72);
            this.btnAuditNode_Resource.TabIndex = 27;
            this.btnAuditNode_Resource.Text = "导入审批节点";
            this.btnAuditNode_Resource.UseVisualStyleBackColor = true;
            this.btnAuditNode_Resource.Click += new System.EventHandler(this.btnAuditNode_Resource_Click);
            // 
            // btnAuditNode_ResourceQA
            // 
            this.btnAuditNode_ResourceQA.Location = new System.Drawing.Point(526, 710);
            this.btnAuditNode_ResourceQA.Name = "btnAuditNode_ResourceQA";
            this.btnAuditNode_ResourceQA.Size = new System.Drawing.Size(191, 72);
            this.btnAuditNode_ResourceQA.TabIndex = 28;
            this.btnAuditNode_ResourceQA.Text = "更新审批节点（QA,PRE）";
            this.btnAuditNode_ResourceQA.UseVisualStyleBackColor = true;
            this.btnAuditNode_ResourceQA.Click += new System.EventHandler(this.btnAuditNode_ResourceQA_Click);
            // 
            // btnSystemCategoryByName
            // 
            this.btnSystemCategoryByName.Location = new System.Drawing.Point(84, 471);
            this.btnSystemCategoryByName.Name = "btnSystemCategoryByName";
            this.btnSystemCategoryByName.Size = new System.Drawing.Size(191, 72);
            this.btnSystemCategoryByName.TabIndex = 29;
            this.btnSystemCategoryByName.Text = "更新品类资源";
            this.btnSystemCategoryByName.UseVisualStyleBackColor = true;
            this.btnSystemCategoryByName.Click += new System.EventHandler(this.btnSystemCategoryByName_Click);
            // 
            // btnSupplierCategory_ResourceByName
            // 
            this.btnSupplierCategory_ResourceByName.Location = new System.Drawing.Point(311, 471);
            this.btnSupplierCategory_ResourceByName.Name = "btnSupplierCategory_ResourceByName";
            this.btnSupplierCategory_ResourceByName.Size = new System.Drawing.Size(191, 72);
            this.btnSupplierCategory_ResourceByName.TabIndex = 35;
            this.btnSupplierCategory_ResourceByName.Text = "更新分供方分类资源";
            this.btnSupplierCategory_ResourceByName.UseVisualStyleBackColor = true;
            this.btnSupplierCategory_ResourceByName.Click += new System.EventHandler(this.btnSupplierCategory_ResourceByName_Click);
            // 
            // tbWriteDB
            // 
            this.tbWriteDB.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbWriteDB.Location = new System.Drawing.Point(326, 103);
            this.tbWriteDB.Name = "tbWriteDB";
            this.tbWriteDB.Size = new System.Drawing.Size(858, 42);
            this.tbWriteDB.TabIndex = 21;
            this.tbWriteDB.Text = " data source=172.16.0.252,14335;database=YZ_AuthCenter\r\n;user id=sa;password=yzw@" +
    "123;Timeout=30;";
            // 
            // btnSystemFunction
            // 
            this.btnSystemFunction.Location = new System.Drawing.Point(526, 471);
            this.btnSystemFunction.Name = "btnSystemFunction";
            this.btnSystemFunction.Size = new System.Drawing.Size(191, 72);
            this.btnSystemFunction.TabIndex = 36;
            this.btnSystemFunction.Text = "更新功能权限";
            this.btnSystemFunction.UseVisualStyleBackColor = true;
            this.btnSystemFunction.Click += new System.EventHandler(this.btnSystemFunction_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(79, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 30);
            this.label1.TabIndex = 38;
            this.label1.Text = "ReadDB：";
            // 
            // tbReadDB
            // 
            this.tbReadDB.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbReadDB.Location = new System.Drawing.Point(326, 34);
            this.tbReadDB.Name = "tbReadDB";
            this.tbReadDB.Size = new System.Drawing.Size(858, 42);
            this.tbReadDB.TabIndex = 37;
            this.tbReadDB.Text = " data source=172.16.0.252,14335;database=YZ_AuthCenter\r\n;user id=sa;password=yzw@" +
    "123;Timeout=30;";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1886, 1169);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbReadDB);
            this.Controls.Add(this.btnSystemFunction);
            this.Controls.Add(this.btnSupplierCategory_ResourceByName);
            this.Controls.Add(this.btnSystemCategoryByName);
            this.Controls.Add(this.btnAuditNode_ResourceQA);
            this.Controls.Add(this.btnAuditNode_Resource);
            this.Controls.Add(this.btnSystemMenu_ResourceQA);
            this.Controls.Add(this.btnSystemMenu_Resource);
            this.Controls.Add(this.btnSystemTagRoleForQA);
            this.Controls.Add(this.btnSystemTagRole);
            this.Controls.Add(this.t);
            this.Controls.Add(this.tbWriteDB);
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
        private System.Windows.Forms.Label t;
        private System.Windows.Forms.Button btnSystemTagRole;
        private System.Windows.Forms.Button btnSystemTagRoleForQA;
        private System.Windows.Forms.Button btnSystemMenu_Resource;
        private System.Windows.Forms.Button btnSystemMenu_ResourceQA;
        private System.Windows.Forms.Button btnAuditNode_Resource;
        private System.Windows.Forms.Button btnAuditNode_ResourceQA;
        private System.Windows.Forms.Button btnSystemCategoryByName;
        private System.Windows.Forms.Button btnSupplierCategory_ResourceByName;
        private System.Windows.Forms.TextBox tbWriteDB;
        private System.Windows.Forms.Button btnSystemFunction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbReadDB;
    }
}

