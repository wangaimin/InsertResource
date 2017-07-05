using Npoi.Mapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using System.Data.SqlClient;

namespace InsertResource
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSystemCategory_Resource_Click(object sender, EventArgs e)
        {

            string path = tbResource.Text.Trim();

            if (tbDBConfig.Text.Trim() == "")
            {
                MessageBox.Show("数据库地址不能为空！");
                return;
            }
            if (path.IndexOf(".xlsx") <= 0)
            {
                MessageBox.Show("请选择正确的excel");
                return;
            }


            var mapper = new Mapper(path);
            var resultData = mapper.Take<SystemCategory_Resource>(0);
            List<SystemCategory_Resource> systemCategory_ResourceList = new List<SystemCategory_Resource>();
            systemCategory_ResourceList.AddRange(resultData.Where(m => m.Value.SystemCategorySysNo != 0).Select(m => m.Value));
            if (systemCategory_ResourceList.Count() == 0)
            {
                MessageBox.Show("确定选择的是品类excel？");
                return;
            }

            foreach (var item in systemCategory_ResourceList)
            {
                item.CategoryName = item.CategoryName.Trim();
            }
            string insertSql = @"INSERT INTO [YZ_Operation].[dbo].[SystemCategory_Resource]
                                   ([SystemCategorySysNo]
                                   ,[LanguageCode]
                                   ,[CategoryName]
                                   ,[InUserSysNo]
                                   ,[InUserName]
                                   ,[InDate]
                                   ,[EditUserSysNo]
                                   ,[EditUserName]
                                   ,[EditDate])
                             VALUES
                                   (@SystemCategorySysNo
                                   ,@LanguageCode
                                   ,@CategoryName
                                    ,0
                                   ,'王爱民'
                                   ,GetDate()
                                   , 0
                                   , '王爱民'
                                   , GetDate())";
            using (IDbConnection conn = new SqlConnection(tbDBConfig.Text.Trim()))
            {
                conn.Open();
                conn.Execute(insertSql, systemCategory_ResourceList);
            }
            MessageBox.Show("成功");
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "(*.xlsx)|*.xlsx";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                tbResource.Text = openFileDialog.FileName;
            }
        }

        private void btnSupplierCategory_Resource_Click(object sender, EventArgs e)
        {

            string path = tbResource.Text.Trim();

            if (tbDBConfig.Text.Trim() == "")
            {
                MessageBox.Show("数据库地址不能为空！");
                return;
            }
            if (path.IndexOf(".xlsx") <= 0)
            {
                MessageBox.Show("请选择正确的excel");
                return;
            }


            var mapper = new Mapper(path);
            var resultData = mapper.Take<SupplierCategory_Resource>(0);
            List<SupplierCategory_Resource> supplierCategory_Resource = new List<SupplierCategory_Resource>();
            supplierCategory_Resource.AddRange(resultData.Where(m => m.Value.SupplierCategorySysNo != 0).Select(m => m.Value));
            if (supplierCategory_Resource.Count() == 0)
            {
                MessageBox.Show("确定选择的是分供方分类excel？");
                return;
            }

            foreach (var item in supplierCategory_Resource)
            {
                item.CategoryName = item.CategoryName.Trim();
            }

            string insertSql = @"INSERT INTO  [YZ_Supplier].[dbo].[SupplierCategory_Resource]
                                   ([SupplierCategorySysNo]
                                   ,[LanguageCode]
                                   ,[CategoryName]
                                   ,[InUserSysNo]
                                   ,[InUserName]
                                   ,[InDate]
                                   ,[EditUserSysNo]
                                   ,[EditUserName]
                                   ,[EditDate])
                             VALUES
                                   (@SupplierCategorySysNo
                                   ,@LanguageCode
                                   ,@CategoryName
                                    ,0
                                   ,'王爱民'
                                   ,GetDate()
                                   , 0
                                   , '王爱民'
                                   , GetDate())";
            using (IDbConnection conn = new SqlConnection(tbDBConfig.Text.Trim()))
            {
                conn.Open();
                conn.Execute(insertSql, supplierCategory_Resource);
            }
            MessageBox.Show("成功");
        }

        private void btnBidTool_TenderBidStatusItem_Resource_Click(object sender, EventArgs e)
        {
            string path = tbResource.Text.Trim();

            if (tbDBConfig.Text.Trim() == "")
            {
                MessageBox.Show("数据库地址不能为空！");
                return;
            }
            if (path.IndexOf(".xlsx") <= 0)
            {
                MessageBox.Show("请选择正确的excel");
                return;
            }


            var mapper = new Mapper(path);
            var resultData = mapper.Take<BidTool_TenderBidStatusItem_Resource>(0);
            List<BidTool_TenderBidStatusItem_Resource> bidTool_TenderBidStatusItem_Resource = new List<BidTool_TenderBidStatusItem_Resource>();
            bidTool_TenderBidStatusItem_Resource.AddRange(resultData.Where(m => m.Value.BidTool_TenderBidStatusItemSysNo != 0).Select(m => m.Value));
            if (bidTool_TenderBidStatusItem_Resource.Count() == 0)
            {
                MessageBox.Show("确定选择的是投标状态excel？");
                return;
            }
            foreach (var item in bidTool_TenderBidStatusItem_Resource)
            {
                item.NoticeContent = item.NoticeContent.Trim();
            }


            string insertSql = @"INSERT INTO [YZ_Tender].[dbo].[BidTool_TenderBidStatusItem_Resource]
                                   ([BidTool_TenderBidStatusItemSysNo]
                                   ,[LanguageCode]
                                   ,[NoticeContent]
                                  )
                             VALUES
                                   (@BidTool_TenderBidStatusItemSysNo
                                   ,@LanguageCode
                                   ,@NoticeContent
                                   )";
            using (IDbConnection conn = new SqlConnection(tbDBConfig.Text.Trim()))
            {
                conn.Open();
                conn.Execute(insertSql, bidTool_TenderBidStatusItem_Resource);
            }
            MessageBox.Show("成功");
        }

        private void btnSystemArea_Resource_Click(object sender, EventArgs e)
        {
            string path = tbResource.Text.Trim();

            if (tbDBConfig.Text.Trim() == "")
            {
                MessageBox.Show("数据库地址不能为空！");
                return;
            }
            if (path.IndexOf(".xlsx") <= 0)
            {
                MessageBox.Show("请选择正确的excel");
                return;
            }


            var mapper = new Mapper(path);
            var resultData = mapper.Take<SystemArea_Resource>(0);
            List<SystemArea_Resource> systemArea_Resource = new List<SystemArea_Resource>();
            systemArea_Resource.AddRange(resultData.Where(m => m.Value.SystemAreaSysNo != 0).Select(m => m.Value));
            if (systemArea_Resource.Count() == 0)
            {
                MessageBox.Show("确定选择的是区域excel？");
                return;
            }

            foreach (var item in systemArea_Resource)
            {
                item.AreaName = item.AreaName.Trim();
            }

            string insertSql = @"INSERT INTO YZ_Operation.[dbo].[SystemArea_Resource]
                                   ([SystemAreaSysNo]
                                   ,[LanguageCode]
                                   ,[AreaName]
                                   ,[InUserSysNo]
                                   ,[InUserName]
                                   ,[InDate]
                                   ,[EditUserSysNo]
                                   ,[EditUserName]
                                   ,[EditDate])
                             VALUES
                                   ( @SystemAreaSysNo
                                   ,@LanguageCode
                                   , @AreaName
                                   ,0
                                   ,'王爱民'
                                   ,GetDate()
                                   , 0
                                   , '王爱民'
                                   , GetDate())";
            using (IDbConnection conn = new SqlConnection(tbDBConfig.Text.Trim()))
            {
                conn.Open();
                conn.Execute(insertSql, systemArea_Resource);
            }
            MessageBox.Show("成功");
        }

        private void btnSystemOrganization_Resource_Click(object sender, EventArgs e)
        {
            string path = tbResource.Text.Trim();

            if (tbDBConfig.Text.Trim() == "")
            {
                MessageBox.Show("数据库地址不能为空！");
                return;
            }
            if (path.IndexOf(".xlsx") <= 0)
            {
                MessageBox.Show("请选择正确的excel");
                return;
            }


            var mapper = new Mapper(path);
            var resultData = mapper.Take<SystemOrganization_Resource>(0);
            List<SystemOrganization_Resource> systemOrganization_Resource = new List<SystemOrganization_Resource>();
            systemOrganization_Resource.AddRange(resultData.Where(m => m.Value.SystemOrganizationSysNo != 0).Select(m => m.Value));
            if (systemOrganization_Resource.Count() == 0)
            {
                MessageBox.Show("确定选择的是组织excel？");
                return;
            }

            foreach (var item in systemOrganization_Resource)
            {
                item.OrganizationName = item.OrganizationName.Trim();
                item.OrganizationFullName = item.OrganizationFullName.Trim();
            }

            string insertSql = @"INSERT INTO [YZ_AuthCenter].[dbo].[SystemOrganization_Resource]
                                   ([SystemOrganizationSysNo]
                                   ,[LanguageCode]
                                   ,[OrganizationName]
                                   ,[OrganizationFullName]
                                   ,[InUserSysNo]
                                   ,[InUserName]
                                   ,[InDate]
                                   ,[EditUserSysNo]
                                   ,[EditUserName]
                                   ,[EditDate])
                             VALUES
                                   (@SystemOrganizationSysNo
                                   , @LanguageCode
                                   , @OrganizationName
                                   , @OrganizationFullName
                                   , @InUserSysNo
                                   , @InUserName
                                   , @InDate
                                   , @EditUserSysNo
                                   , @EditUserName
                                   , @EditDate)";
            using (IDbConnection conn = new SqlConnection(tbDBConfig.Text.Trim()))
            {
                conn.Open();
                conn.Execute(insertSql, systemOrganization_Resource);
            }
            MessageBox.Show("成功");
        }

        private void btSystemTagRole_Click(object sender, EventArgs e)
        {
            string path = tbResource.Text.Trim();

            if (tbDBConfig.Text.Trim() == "")
            {
                MessageBox.Show("数据库地址不能为空！");
                return;
            }
            if (path.IndexOf(".xlsx") <= 0)
            {
                MessageBox.Show("请选择正确的excel");
                return;
            }


            var mapper = new Mapper(path);
            var resultData = mapper.Take<SystemTagRole_Resource>(0);
            List<SystemTagRole_Resource> systemTagRole_Resource = new List<SystemTagRole_Resource>();
            systemTagRole_Resource.AddRange(resultData.Select(m => m.Value));
            if (systemTagRole_Resource.Count() == 0)
            {
                MessageBox.Show("确定选择的是角色类型excel？");
                return;
            }

            systemTagRole_Resource.ForEach(m => m.RoleName = m.RoleName.Trim());

            string insertSql = @"INSERT INTO [YZ_AuthCenter].[dbo].[SystemTagRole_Resource]
                                               ([RoleSysNo]
                                               ,[LanguageCode]
                                               ,[RoleName])
                                         VALUES
                                               (@RoleSysNo
                                               ,@LanguageCode
                                               ,@RoleName)";
            using (IDbConnection conn = new SqlConnection(tbDBConfig.Text.Trim()))
            {
                conn.Open();
                conn.Execute(insertSql, systemTagRole_Resource);
            }
            MessageBox.Show("成功");
        }

        private void btSystemTagRoleForQA_Click(object sender, EventArgs e)
        {
            string path = tbResource.Text.Trim();

            if (tbDBConfig.Text.Trim() == "")
            {
                MessageBox.Show("数据库地址不能为空！");
                return;
            }
            if (path.IndexOf(".xlsx") <= 0)
            {
                MessageBox.Show("请选择正确的excel");
                return;
            }

            string insertSql = @"INSERT INTO [YZ_AuthCenter].[dbo].[SystemTagRole_Resource]
                                               ([RoleSysNo]
                                               ,[LanguageCode]
                                               ,[RoleName])
                                         VALUES
                                               (@RoleSysNo
                                               ,@LanguageCode
                                               ,@RoleName)";

            string querySql = "SELECT [SysNo] AS RoleSysNo ,[RoleName] AS RoleName_zh_cn FROM [YZ_AuthCenter].[dbo].[SystemTagRole] WITH(NOLOCK)";


            var mapper = new Mapper(path);
            var resultData = mapper.Take<SystemTagRole_Resource>(0);
            Dictionary<string, SystemTagRole_Resource> dicDistinctName = new Dictionary<string, SystemTagRole_Resource>();
            resultData.Select(m => m.Value).ForEach(m =>
            {
                if (!dicDistinctName.ContainsKey(m.RoleName_zh_cn))
                {
                    dicDistinctName.Add(m.RoleName_zh_cn, m);
                }
            });

            if (dicDistinctName.Count() == 0)
            {
                MessageBox.Show("确定选择的是角色类型excel？");
                return;
            }


            using (IDbConnection conn = new SqlConnection(tbDBConfig.Text.Trim()))
            {
                conn.Open();
                var systemTagRole_Resource = conn.Query<SystemTagRole_Resource>(querySql);

                dicDistinctName.ForEach(m=> {
                    systemTagRole_Resource.Where(str => str.RoleName_zh_cn.Equals(m.Key)).ForEach(str=> 
                    {
                        str.RoleName = m.Value.RoleName.Trim();
                        str.LanguageCode = m.Value.LanguageCode;
                    }
                    );
                });

                var result = systemTagRole_Resource.Where(m=>m.RoleName!="");

                conn.Execute(insertSql, result);
            }
            MessageBox.Show("成功");
        }

        private void btnSystemMenu_Resource_Click(object sender, EventArgs e)
        {
            string path = tbResource.Text.Trim();

            if (tbDBConfig.Text.Trim() == "")
            {
                MessageBox.Show("数据库地址不能为空！");
                return;
            }
            if (path.IndexOf(".xlsx") <= 0)
            {
                MessageBox.Show("请选择正确的excel");
                return;
            }


            var mapper = new Mapper(path);
            var resultData = mapper.Take<SystemMenu_Resource>(0);
            List<SystemMenu_Resource> systemMenu_Resource = new List<SystemMenu_Resource>();
            systemMenu_Resource.AddRange(resultData.Select(m => m.Value));
            if (systemMenu_Resource.Count() == 0)
            {
                MessageBox.Show("确定选择的是菜单excel？");
                return;
            }

            systemMenu_Resource.ForEach(m => m.MenuName = m.MenuName.Trim());

            string insertSql = @"INSERT INTO [YZ_AuthCenter].[dbo].[SystemMenu_Resource]
                                               ([MenuSysNo]
                                               ,[LanguageCode]
                                               ,[MenuName])
                                         VALUES
                                               (@MenuSysNo
                                               ,@LanguageCode
                                               ,@MenuName)";
            using (IDbConnection conn = new SqlConnection(tbDBConfig.Text.Trim()))
            {
                conn.Open();
                conn.Execute(insertSql, systemMenu_Resource);
            }
            MessageBox.Show("成功");

        }

        private void btnSystemMenu_ResourceQA_Click(object sender, EventArgs e)
        {
            string path = tbResource.Text.Trim();

            if (tbDBConfig.Text.Trim() == "")
            {
                MessageBox.Show("数据库地址不能为空！");
                return;
            }
            if (path.IndexOf(".xlsx") <= 0)
            {
                MessageBox.Show("请选择正确的excel");
                return;
            }

            string insertSql = @"INSERT INTO [YZ_AuthCenter].[dbo].[SystemMenu_Resource]
                                               ([MenuSysNo]
                                               ,[LanguageCode]
                                               ,[MenuName])
                                         VALUES
                                               (@MenuSysNo
                                               ,@LanguageCode
                                               ,@MenuName)";

            string querySql = "SELECT [SysNo] AS MenuSysNo ,[MenuName] AS MenuName_zh_cn FROM [YZ_AuthCenter].[dbo].[SystemMenu] WITH(NOLOCK)";


            var mapper = new Mapper(path);
            var resultData = mapper.Take<SystemMenu_Resource>(0);
            Dictionary<string, SystemMenu_Resource> dicDistinctName = new Dictionary<string, SystemMenu_Resource>();
            resultData.Select(m => m.Value).ForEach(m =>
            {
                if (!dicDistinctName.ContainsKey(m.MenuName_zh_cn))
                {
                    dicDistinctName.Add(m.MenuName_zh_cn, m);
                }
            });

            if (dicDistinctName.Count() == 0)
            {
                MessageBox.Show("确定选择的是菜单excel？");
                return;
            }


            using (IDbConnection conn = new SqlConnection(tbDBConfig.Text.Trim()))
            {
                conn.Open();
                var systemMenu_Resource = conn.Query<SystemMenu_Resource>(querySql);

                dicDistinctName.ForEach(m => {
                    systemMenu_Resource.Where(str => str.MenuName_zh_cn.Equals(m.Key)).ForEach(str =>
                    {
                        str.MenuName = m.Value.MenuName.Trim();
                        str.LanguageCode = m.Value.LanguageCode;
                    }
                    );
                });

                var result = systemMenu_Resource.Where(m => m.MenuName != "");

                conn.Execute(insertSql, result);
            }
            MessageBox.Show("成功");

        }

        private void btnAuditNode_Resource_Click(object sender, EventArgs e)
        {
            string path = tbResource.Text.Trim();

            if (tbDBConfig.Text.Trim() == "")
            {
                MessageBox.Show("数据库地址不能为空！");
                return;
            }
            if (path.IndexOf(".xlsx") <= 0)
            {
                MessageBox.Show("请选择正确的excel");
                return;
            }


            var mapper = new Mapper(path);
            var resultData = mapper.Take<AuditNode_Resource>(0);
            List<AuditNode_Resource> auditNode_Resource = new List<AuditNode_Resource>();
            auditNode_Resource.AddRange(resultData.Select(m => m.Value));
            if (auditNode_Resource.Count() == 0)
            {
                MessageBox.Show("确定选择的是菜单excel？");
                return;
            }

            auditNode_Resource.ForEach(m =>
            {
                m.NodeName = m.NodeName.Trim();
                m.ApplicationName = m.ApplicationName.Trim();
            });

            string insertSql = @"INSERT INTO [YZ_Audit].[dbo].[AuditNode_Resource]
                                               ([NodeSysNo]
                                               ,[LanguageCode]
                                               ,[NodeName]
                                               ,[ApplicationName])
                                         VALUES
                                               (@NodeSysNo
                                               ,@LanguageCode
                                               ,@NodeName
                                               ,@ApplicationName)";
            using (IDbConnection conn = new SqlConnection(tbDBConfig.Text.Trim()))
            {
                conn.Open();
                conn.Execute(insertSql, auditNode_Resource);
            }
            MessageBox.Show("成功");

        }

        private void btnAuditNode_ResourceQA_Click(object sender, EventArgs e)
        {
            string path = tbResource.Text.Trim();

            if (tbDBConfig.Text.Trim() == "")
            {
                MessageBox.Show("数据库地址不能为空！");
                return;
            }
            if (path.IndexOf(".xlsx") <= 0)
            {
                MessageBox.Show("请选择正确的excel");
                return;
            }

            string insertSql = @"INSERT INTO [YZ_Audit].[dbo].[AuditNode_Resource]
                                               ([NodeSysNo]
                                               ,[LanguageCode]
                                               ,[NodeName]
                                               ,[ApplicationName])
                                         VALUES
                                               (@NodeSysNo
                                               ,@LanguageCode
                                               ,@NodeName
                                               ,@ApplicationName)";

            string querySql = "SELECT [SysNo] AS NodeSysNo ,[NodeName] AS NodeName_zh_cn FROM [YZ_Audit].[dbo].[AuditNode] WITH(NOLOCK)";


            var mapper = new Mapper(path);
            var resultData = mapper.Take<AuditNode_Resource>(0);
            Dictionary<string, AuditNode_Resource> dicDistinctName = new Dictionary<string, AuditNode_Resource>();
            resultData.Select(m => m.Value).ForEach(m =>
            {
                if (!dicDistinctName.ContainsKey(m.NodeName_zh_cn))
                {
                    dicDistinctName.Add(m.NodeName_zh_cn, m);
                }
            });

            if (dicDistinctName.Count() == 0)
            {
                MessageBox.Show("确定选择的是审批节点excel？");
                return;
            }


            using (IDbConnection conn = new SqlConnection(tbDBConfig.Text.Trim()))
            {
                conn.Open();
                var auditNode_Resource = conn.Query<AuditNode_Resource>(querySql);

                dicDistinctName.ForEach(m => {
                    auditNode_Resource.Where(str => str.NodeName_zh_cn.Equals(m.Key)).ForEach(str =>
                    {
                        str.NodeName = m.Value.NodeName.Trim();
                        str.ApplicationName = m.Value.ApplicationName.Trim();
                        str.LanguageCode = m.Value.LanguageCode;
                    }
                    );
                });

                var result = auditNode_Resource.Where(m => m.NodeName != "");

                conn.Execute(insertSql, result);
            }
            MessageBox.Show("成功");
        }
    }
}
