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
            if (systemCategory_ResourceList.Count()==0)
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
    }
}
