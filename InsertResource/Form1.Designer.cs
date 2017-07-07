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
            this.label2 = new System.Windows.Forms.Label();
            this.btnSystemTagRole = new System.Windows.Forms.Button();
            this.btnSystemTagRoleForQA = new System.Windows.Forms.Button();
            this.btnSystemMenu_Resource = new System.Windows.Forms.Button();
            this.btnSystemMenu_ResourceQA = new System.Windows.Forms.Button();
            this.btnAuditNode_Resource = new System.Windows.Forms.Button();
            this.btnAuditNode_ResourceQA = new System.Windows.Forms.Button();
            this.btnSystemCategoryByName = new System.Windows.Forms.Button();
            this.btnSupplierCategory_ResourceByName = new System.Windows.Forms.Button();
            this.tbDBConfig = new System.Windows.Forms.TextBox();
            this.btnSystemFunction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(83, 140);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(191, 72);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "选择数据";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // tbResource
            // 
            this.tbResource.Location = new System.Drawing.Point(326, 140);
            this.tbResource.Multiline = true;
            this.tbResource.Name = "tbResource";
            this.tbResource.Size = new System.Drawing.Size(858, 72);
            this.tbResource.TabIndex = 1;
            this.tbResource.Text = "C:\\Users\\admin\\Desktop\\DB翻译\\已翻译\\区域.xlsx";
            // 
            // btnSupplierCategory_Resource
            // 
            this.btnSupplierCategory_Resource.Location = new System.Drawing.Point(311, 303);
            this.btnSupplierCategory_Resource.Name = "btnSupplierCategory_Resource";
            this.btnSupplierCategory_Resource.Size = new System.Drawing.Size(191, 72);
            this.btnSupplierCategory_Resource.TabIndex = 2;
            this.btnSupplierCategory_Resource.Text = "导入分供方分类资源";
            this.btnSupplierCategory_Resource.UseVisualStyleBackColor = true;
            this.btnSupplierCategory_Resource.Click += new System.EventHandler(this.btnSupplierCategory_Resource_Click);
            // 
            // btnSystemCategory_Resource
            // 
            this.btnSystemCategory_Resource.Location = new System.Drawing.Point(83, 303);
            this.btnSystemCategory_Resource.Name = "btnSystemCategory_Resource";
            this.btnSystemCategory_Resource.Size = new System.Drawing.Size(191, 72);
            this.btnSystemCategory_Resource.TabIndex = 3;
            this.btnSystemCategory_Resource.Text = "导入品类资源";
            this.btnSystemCategory_Resource.UseVisualStyleBackColor = true;
            this.btnSystemCategory_Resource.Click += new System.EventHandler(this.btnSystemCategory_Resource_Click);
            // 
            // btnBidTool_TenderBidStatusItem_Resource
            // 
            this.btnBidTool_TenderBidStatusItem_Resource.Location = new System.Drawing.Point(526, 303);
            this.btnBidTool_TenderBidStatusItem_Resource.Name = "btnBidTool_TenderBidStatusItem_Resource";
            this.btnBidTool_TenderBidStatusItem_Resource.Size = new System.Drawing.Size(191, 72);
            this.btnBidTool_TenderBidStatusItem_Resource.TabIndex = 4;
            this.btnBidTool_TenderBidStatusItem_Resource.Text = "导入招标状态资源";
            this.btnBidTool_TenderBidStatusItem_Resource.UseVisualStyleBackColor = true;
            this.btnBidTool_TenderBidStatusItem_Resource.Click += new System.EventHandler(this.btnBidTool_TenderBidStatusItem_Resource_Click);
            // 
            // btnSystemOrganization_Resource
            // 
            this.btnSystemOrganization_Resource.Location = new System.Drawing.Point(747, 303);
            this.btnSystemOrganization_Resource.Name = "btnSystemOrganization_Resource";
            this.btnSystemOrganization_Resource.Size = new System.Drawing.Size(191, 72);
            this.btnSystemOrganization_Resource.TabIndex = 5;
            this.btnSystemOrganization_Resource.Text = "导入组织资源";
            this.btnSystemOrganization_Resource.UseVisualStyleBackColor = true;
            this.btnSystemOrganization_Resource.Click += new System.EventHandler(this.btnSystemOrganization_Resource_Click);
            // 
            // btnSystemArea_Resource
            // 
            this.btnSystemArea_Resource.Location = new System.Drawing.Point(967, 303);
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
            this.label2.Location = new System.Drawing.Point(79, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 30);
            this.label2.TabIndex = 22;
            this.label2.Text = "数据库地址：";
            // 
            // btnSystemTagRole
            // 
            this.btnSystemTagRole.Location = new System.Drawing.Point(81, 534);
            this.btnSystemTagRole.Name = "btnSystemTagRole";
            this.btnSystemTagRole.Size = new System.Drawing.Size(191, 72);
            this.btnSystemTagRole.TabIndex = 23;
            this.btnSystemTagRole.Text = "导入角色类型资源";
            this.btnSystemTagRole.UseVisualStyleBackColor = true;
            this.btnSystemTagRole.Click += new System.EventHandler(this.btSystemTagRole_Click);
            // 
            // btnSystemTagRoleForQA
            // 
            this.btnSystemTagRoleForQA.Location = new System.Drawing.Point(81, 637);
            this.btnSystemTagRoleForQA.Name = "btnSystemTagRoleForQA";
            this.btnSystemTagRoleForQA.Size = new System.Drawing.Size(191, 72);
            this.btnSystemTagRoleForQA.TabIndex = 24;
            this.btnSystemTagRoleForQA.Text = "更新角色类型资源(QA,PRE)";
            this.btnSystemTagRoleForQA.UseVisualStyleBackColor = true;
            this.btnSystemTagRoleForQA.Click += new System.EventHandler(this.btSystemTagRoleForQA_Click);
            // 
            // btnSystemMenu_Resource
            // 
            this.btnSystemMenu_Resource.Location = new System.Drawing.Point(297, 534);
            this.btnSystemMenu_Resource.Name = "btnSystemMenu_Resource";
            this.btnSystemMenu_Resource.Size = new System.Drawing.Size(191, 72);
            this.btnSystemMenu_Resource.TabIndex = 25;
            this.btnSystemMenu_Resource.Text = "导入菜单资源";
            this.btnSystemMenu_Resource.UseVisualStyleBackColor = true;
            this.btnSystemMenu_Resource.Click += new System.EventHandler(this.btnSystemMenu_Resource_Click);
            // 
            // btnSystemMenu_ResourceQA
            // 
            this.btnSystemMenu_ResourceQA.Location = new System.Drawing.Point(297, 637);
            this.btnSystemMenu_ResourceQA.Name = "btnSystemMenu_ResourceQA";
            this.btnSystemMenu_ResourceQA.Size = new System.Drawing.Size(191, 72);
            this.btnSystemMenu_ResourceQA.TabIndex = 26;
            this.btnSystemMenu_ResourceQA.Text = "更新菜单资源（QA,PRE）";
            this.btnSystemMenu_ResourceQA.UseVisualStyleBackColor = true;
            this.btnSystemMenu_ResourceQA.Click += new System.EventHandler(this.btnSystemMenu_ResourceQA_Click);
            // 
            // btnAuditNode_Resource
            // 
            this.btnAuditNode_Resource.Location = new System.Drawing.Point(526, 534);
            this.btnAuditNode_Resource.Name = "btnAuditNode_Resource";
            this.btnAuditNode_Resource.Size = new System.Drawing.Size(191, 72);
            this.btnAuditNode_Resource.TabIndex = 27;
            this.btnAuditNode_Resource.Text = "导入审批节点";
            this.btnAuditNode_Resource.UseVisualStyleBackColor = true;
            this.btnAuditNode_Resource.Click += new System.EventHandler(this.btnAuditNode_Resource_Click);
            // 
            // btnAuditNode_ResourceQA
            // 
            this.btnAuditNode_ResourceQA.Location = new System.Drawing.Point(526, 637);
            this.btnAuditNode_ResourceQA.Name = "btnAuditNode_ResourceQA";
            this.btnAuditNode_ResourceQA.Size = new System.Drawing.Size(191, 72);
            this.btnAuditNode_ResourceQA.TabIndex = 28;
            this.btnAuditNode_ResourceQA.Text = "更新审批节点（QA,PRE）";
            this.btnAuditNode_ResourceQA.UseVisualStyleBackColor = true;
            this.btnAuditNode_ResourceQA.Click += new System.EventHandler(this.btnAuditNode_ResourceQA_Click);
            // 
            // btnSystemCategoryByName
            // 
            this.btnSystemCategoryByName.Location = new System.Drawing.Point(84, 398);
            this.btnSystemCategoryByName.Name = "btnSystemCategoryByName";
            this.btnSystemCategoryByName.Size = new System.Drawing.Size(191, 72);
            this.btnSystemCategoryByName.TabIndex = 29;
            this.btnSystemCategoryByName.Text = "更新品类资源";
            this.btnSystemCategoryByName.UseVisualStyleBackColor = true;
            this.btnSystemCategoryByName.Click += new System.EventHandler(this.btnSystemCategoryByName_Click);
            // 
            // btnSupplierCategory_ResourceByName
            // 
            this.btnSupplierCategory_ResourceByName.Location = new System.Drawing.Point(311, 398);
            this.btnSupplierCategory_ResourceByName.Name = "btnSupplierCategory_ResourceByName";
            this.btnSupplierCategory_ResourceByName.Size = new System.Drawing.Size(191, 72);
            this.btnSupplierCategory_ResourceByName.TabIndex = 35;
            this.btnSupplierCategory_ResourceByName.Text = "更新分供方分类资源";
            this.btnSupplierCategory_ResourceByName.UseVisualStyleBackColor = true;
            this.btnSupplierCategory_ResourceByName.Click += new System.EventHandler(this.btnSupplierCategory_ResourceByName_Click);
            // 
            // tbDBConfig
            // 
            this.tbDBConfig.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbDBConfig.Location = new System.Drawing.Point(326, 30);
            this.tbDBConfig.Name = "tbDBConfig";
            this.tbDBConfig.Size = new System.Drawing.Size(858, 42);
            this.tbDBConfig.TabIndex = 21;
            this.tbDBConfig.Text = " data source=.;database=YZ_Operation\r\n;user id=sa;password=yzw@123;Timeout=30;";
            // 
            // btnSystemFunction
            // 
            this.btnSystemFunction.Location = new System.Drawing.Point(526, 398);
            this.btnSystemFunction.Name = "btnSystemFunction";
            this.btnSystemFunction.Size = new System.Drawing.Size(191, 72);
            this.btnSystemFunction.TabIndex = 36;
            this.btnSystemFunction.Text = "更新功能权限";
            this.btnSystemFunction.UseVisualStyleBackColor = true;
            this.btnSystemFunction.Click += new System.EventHandler(this.btnSystemFunction_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1859, 892);
            this.Controls.Add(this.btnSystemFunction);
            this.Controls.Add(this.btnSupplierCategory_ResourceByName);
            this.Controls.Add(this.btnSystemCategoryByName);
            this.Controls.Add(this.btnAuditNode_ResourceQA);
            this.Controls.Add(this.btnAuditNode_Resource);
            this.Controls.Add(this.btnSystemMenu_ResourceQA);
            this.Controls.Add(this.btnSystemMenu_Resource);
            this.Controls.Add(this.btnSystemTagRoleForQA);
            this.Controls.Add(this.btnSystemTagRole);
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
        private System.Windows.Forms.Button btnSystemTagRole;
        private System.Windows.Forms.Button btnSystemTagRoleForQA;
        private System.Windows.Forms.Button btnSystemMenu_Resource;
        private System.Windows.Forms.Button btnSystemMenu_ResourceQA;
        private System.Windows.Forms.Button btnAuditNode_Resource;
        private System.Windows.Forms.Button btnAuditNode_ResourceQA;
        private System.Windows.Forms.Button btnSystemCategoryByName;
        private System.Windows.Forms.Button btnSupplierCategory_ResourceByName;
        private System.Windows.Forms.TextBox tbDBConfig;
        private System.Windows.Forms.Button btnSystemFunction;
    }
}

