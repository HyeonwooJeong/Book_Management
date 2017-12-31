using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Book_Management
{
    public partial class Form1 : Form
    {
        string imgFileName;
        List<Books> list = new List<Books>();

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 책 저장
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (checkTextBox() && checkPk())
            {
                gvBookView.DataSource = null;

                string isbn = this.txtISBN.Text;
                string name = this.txtName.Text;
                string author = this.txtAuthor.Text.Trim().Replace(" ", "");
                string price = this.txtPrice.Text.Substring(0, 6).Replace(",", "");
                string summary = this.txtSummary.Text;
                string category = this.cboCategory.SelectedItem.ToString();

                #region 내용 테스트
                //MessageBox.Show("isbn: " + isbn + "\n" + "이름: " + name + "\n" + "저자: " + author + "\n" + "가격: " + price + "\n" + "요약: " + summary + "\n" + "분류: " + category);
                #endregion

                FileStream fs = new FileStream(imgFileName.ToString(), FileMode.Open, FileAccess.Read);
                byte[] bImg = new byte[fs.Length];
                fs.Read(bImg, 0, (int)fs.Length);

                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["compactDb"].ConnectionString))
                {
                    using (var cmd = new SqlCommand("AddBook", con))
                    {
                        // 실행할 쿼리문이 저장프로시저에 있다.
                        cmd.CommandType = CommandType.StoredProcedure;

                        // 저장프로시저 실행에 필요한 파라메터를 지정
                        cmd.Parameters.AddWithValue("@addIsbn", isbn);
                        cmd.Parameters.AddWithValue("@addName", name);
                        cmd.Parameters.AddWithValue("@addAuthor", author);
                        cmd.Parameters.AddWithValue("@addPrice", price);
                        cmd.Parameters.AddWithValue("@addSummary", summary);
                        cmd.Parameters.AddWithValue("@addImage", bImg);
                        cmd.Parameters.AddWithValue("@addCategory", category);

                        con.Open();
                        //gvBookView.DataSource = null;
                        //listUpdate();
                        //gvBookViewSettings();
                        //gvBookView.DataSource = list;

                        list.Add(new Books()
                        {
                            Isbn = isbn,
                            Name = name,
                            Author = author,
                            Price = price,
                            Summary = summary,
                            Category = category
                        });
                        gvBookView.DataSource = list;
                        gvBookViewSettings();

                        int i = cmd.ExecuteNonQuery(); // select을 제외한 나머지는 ExecuteNonQuery 사용한다.
                        if (i == 1)
                        {
                            txtReset();
                            MessageBox.Show("저장이 잘 되었습니다!");
                            return;
                        }
                        else
                        {
                            MessageBox.Show("저장 실패");
                            return;
                        }
                    }
                } 
            }
            else
            {
                MessageBox.Show("데이터가 유효하지 않습니다.");
            }
        }

        /// <summary>
        /// 기본키 유효성 검사
        /// </summary>
        /// <returns></returns>
        private bool checkPk()
        {
            string checkIsbn = this.txtISBN.Text.Trim().Replace(" ", "");
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["compactDb"].ConnectionString))
            {
                using (var cmd = new SqlCommand("checkPk", con))
                {
                    // 실행할 쿼리문이 저장프로시저에 있다.
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@checkIsbn", checkIsbn);
                    con.Open();

                    var sdr = cmd.ExecuteReader();
                    if (sdr.HasRows)
                    {
                        MessageBox.Show("중복되는 책 항목이 있습니다.");
                        txtReset();
                        sdr.Close();
                        con.Close();
                        return false;
                    }
                    else
                    {
                        sdr.Close();
                        con.Close();
                        return true;
                    }
                }
            }
        }

        /// <summary>
        /// 공백 여부 검사
        /// </summary>
        /// <returns></returns>
        private bool checkTextBox()
        {
            if (this.txtISBN.Text == "")
            {
                return false;
            }
            else if (this.txtName.Text == "")
            {
                return false;
            }
            else if (this.txtAuthor.Text == "")
            {
                return false;
            }
            else if (this.txtPrice.Text == "")
            {
                return false;
            }
            else if (this.cboCategory.Text == "")
            {
                return false;
            }
            else if (this.imgFileName == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// 이미지 추가
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImageAdd_Click(object sender, EventArgs e)
        {
            imgFileName = null;
            var dlg = imageDialog.ShowDialog();
            if (dlg == DialogResult.OK)
            {
                picBook.Image = new Bitmap(imageDialog.FileName);
                imgFileName = imageDialog.FileName;
            }
        }

        /// <summary>
        /// 프로그램 시작
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["compactDb"].ConnectionString))
            //{
            //    listUpdate();
            //}
        }

        /// <summary>
        /// 그리드뷰에서 책 항목 선택
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gvBookView_Click(object sender, EventArgs e)
        {
            this.txtISBN.Text = this.gvBookView.CurrentRow.Cells[0].Value.ToString();
            this.txtName.Text = this.gvBookView.CurrentRow.Cells[1].Value.ToString();
            this.txtAuthor.Text = this.gvBookView.CurrentRow.Cells[2].Value.ToString();
            this.txtPrice.Text = this.gvBookView.CurrentRow.Cells[3].Value.ToString();
            this.txtSummary.Text = this.gvBookView.CurrentRow.Cells[4].Value.ToString();
            this.cboCategory.Text = this.gvBookView.CurrentRow.Cells[5].Value.ToString();

            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["compactDb"].ConnectionString))
            {
                using (var cmd = new SqlCommand("ImageBook", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@imageIsbn", this.txtISBN.Text);

                    con.Open();

                    byte[] img = null;

                    var sdr = cmd.ExecuteReader();
                    if (sdr.HasRows)
                    {
                        while (sdr.Read())
                        {
                            if (sdr["Image"] != null)
                            {
                                try
                                {
                                    img = (byte[])sdr["Image"];
                                    picBook.Image = new Bitmap(new MemoryStream(img));
                                }
                                catch (Exception)
                                {
                                    picBook.Image = null;
                                }
                            }

                        }
                    }
                    else
                    {
                        return;
                    }
                    sdr.Close();
                }
            }
        }

        /// <summary>
        /// 책 이름 검색
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // 한글은 공백을 유의해야한다!!
            string findName = txtSearch.Text;

            //using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["compactDb"].ConnectionString))
            //{

            //    gvBookView.DataSource = null;
            //    list.Clear();

            //    using (var cmd = new SqlCommand("SearchBook", con))
            //    {
            //        cmd.CommandType = CommandType.StoredProcedure;

            //        cmd.Parameters.AddWithValue("@searchName", findName);
            //        con.Open();
            //        var sdr = cmd.ExecuteReader();

            //        if (!sdr.HasRows)
            //        {
            //            return;
            //        }
            //        else
            //        {
            //            while (sdr.Read())
            //            {
            //                list.Add(new Books()
            //                {
            //                    Isbn = sdr["Isbn"].ToString(),
            //                    Name = sdr["Name"].ToString(),
            //                    Author = sdr["Author"].ToString(),
            //                    Price = sdr["Price"].ToString(),
            //                    Summary = sdr["Summary"].ToString(),
            //                    Category = sdr["Category"].ToString(),
            //                });
            //            }

            //            this.gvBookView.DataSource = list;
            //            gvBookViewSettings();
            //            sdr.Close();
            //        }
            //    }
            //}
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["compactDb"].ConnectionString))
            {
                con.Open();
                string query = "select * from dbo.Books where name like N'%" + findName + "%'";
                using (var cmd = new SqlCommand(query, con))
                {
                    var sdr = cmd.ExecuteReader();
                    if (!sdr.HasRows)
                    {
                        MessageBox.Show("친구가 없다!");
                        return;
                    }
                    else
                    {
                        while (sdr.Read())
                        {
                            list.Add(new Books()
                            {
                                Isbn = sdr["Isbn"].ToString(),
                                Name = sdr["Name"].ToString(),
                                Author = sdr["Author"].ToString(),
                                Price = sdr["Price"].ToString(),
                                Summary = sdr["Summary"].ToString(),
                                Category = sdr["Category"].ToString(),
                            });
                        }

                        this.gvBookView.DataSource = list;
                        sdr.Close();
                        // cmd는 using이 끝나면 자동으로 닫는다.
                    }
                }
            }
        }

        /// <summary>
        /// 책 삭제
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["compactDb"].ConnectionString))
            {
                using (var cmd = new SqlCommand("DeleteBook", con))
                {
                    // 실행할 쿼리문이 저장프로시저에 있다.
                    cmd.CommandType = CommandType.StoredProcedure;

                    // 저장프로시저 실행에 필요한 파라메터를 지정
                    cmd.Parameters.AddWithValue("@DeleteIsbn", this.txtISBN.Text);

                    con.Open();

                    int i = cmd.ExecuteNonQuery(); // select을 제외한 나머지는 ExecuteNonQuery 사용한다.
                    if (i == 1)
                    {
                        list.RemoveAt(gvBookView.CurrentRow.Cells[0].RowIndex);
                        gvBookView.DataSource = null;
                        gvBookView.DataSource = list;
                        gvBookViewSettings();
                        list.Clear();
                        listUpdate();
                        txtReset();
                        MessageBox.Show("삭제가 완료되었습니다.");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("삭제할 정보가 없습니다.");
                        return;
                    }
                }
            }
        }

        /// <summary>
        /// 그리드뷰 데이터 갱신
        /// </summary>
        private void listUpdate()
        {
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["compactDb"].ConnectionString))
            {
                con.Open();
                gvBookView.DataSource = null;

                using (var cmd = new SqlCommand("ViewBook", con))
                {
                    var sdr = cmd.ExecuteReader();
                    if (!sdr.HasRows)
                    {
                        return;
                    }
                    else
                    {
                        while (sdr.Read())
                        {
                            list.Add(new Books()
                            {
                                Isbn = sdr["Isbn"].ToString(),
                                Name = sdr["Name"].ToString(),
                                Author = sdr["Author"].ToString(),
                                Price = sdr["Price"].ToString(),
                                Summary = sdr["Summary"].ToString(),
                                Category = sdr["Category"].ToString(),
                            });
                        }

                        this.gvBookView.DataSource = list;
                        gvBookViewSettings();
                        sdr.Close();
                    }
                }
            }
        }

        private void gvBookViewSettings()
        {
            // 열 이름 설정
            this.gvBookView.Columns[0].HeaderText = "ISBN";
            this.gvBookView.Columns[1].HeaderText = "책 이름";
            this.gvBookView.Columns[2].HeaderText = "저자";
            this.gvBookView.Columns[3].HeaderText = "가격";
            this.gvBookView.Columns[4].HeaderText = "내용요약";
            this.gvBookView.Columns[5].HeaderText = "카테고리";

            // 열 크기 설정
            this.gvBookView.Columns[1].Width = 208;
            this.gvBookView.Columns[4].Width = 300;
        }

        /// <summary>
        /// 책 수정
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            gvBookView.DataSource = null;

            string isbn = this.txtISBN.Text;
            string name = this.txtName.Text;
            string author = this.txtAuthor.Text.Trim().Replace(" ", "");
            string price = this.txtPrice.Text.Substring(0, 6).Replace(",", "");
            string summary = this.txtSummary.Text;
            string category = this.cboCategory.SelectedItem.ToString();

            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["compactDb"].ConnectionString))
            {

                using (var cmd = new SqlCommand("NoImageEditBook", con))
                {
                    // 실행할 쿼리문이 저장프로시저에 있다.
                    cmd.CommandType = CommandType.StoredProcedure;

                    // 저장프로시저 실행에 필요한 파라메터를 지정
                    cmd.Parameters.AddWithValue("@editIsbn", isbn);
                    cmd.Parameters.AddWithValue("@editName", name);
                    cmd.Parameters.AddWithValue("@editAuthor", author);
                    cmd.Parameters.AddWithValue("@editPrice", price);
                    cmd.Parameters.AddWithValue("@editSummary", summary);
                    cmd.Parameters.AddWithValue("@editCategory", category);

                    con.Open();
                    //this.gvBookView.DataSource = list;

                    int i = cmd.ExecuteNonQuery(); // select을 제외한 나머지는 ExecuteNonQuery 사용한다.
                    if (i == 1)
                    {
                        gvBookView.DataSource = null;
                        gvBookView.DataSource = list;
                        gvBookViewSettings();
                        list.Clear();
                        listUpdate();
                        txtReset();
                        MessageBox.Show("정상적으로 수정 되었습니다.");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("수정 실패하였습니다.");
                        return;
                    }
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtReset();
        }

        private void txtReset()
        {
            this.txtISBN.Text = "";
            this.txtName.Text = "";
            this.txtAuthor.Text = "";
            this.txtPrice.Text = "";
            this.txtSummary.Text = "";
            this.cboCategory.Text = null;
            this.picBook.Image = null;
        }

        private void btnEditImage_Click(object sender, EventArgs e)
        {
            string isbn = this.txtISBN.Text;
            string name = this.txtName.Text;
            string author = this.txtAuthor.Text.Trim().Replace(" ", "");
            string price = this.txtPrice.Text.Substring(0, 6).Replace(",", "");
            string summary = this.txtSummary.Text;
            string category = this.cboCategory.SelectedItem.ToString();

            FileStream fs = new FileStream(imgFileName.ToString(), FileMode.Open, FileAccess.Read);
            byte[] bImg = new byte[fs.Length];
            fs.Read(bImg, 0, (int)fs.Length);

            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["compactDb"].ConnectionString))
            {

                using (var cmd = new SqlCommand("ImageEditBook", con))
                {
                    // 실행할 쿼리문이 저장프로시저에 있다.
                    cmd.CommandType = CommandType.StoredProcedure;

                    // 저장프로시저 실행에 필요한 파라메터를 지정
                    cmd.Parameters.AddWithValue("@editIsbn", isbn);
                    cmd.Parameters.AddWithValue("@editName", name);
                    cmd.Parameters.AddWithValue("@editAuthor", author);
                    cmd.Parameters.AddWithValue("@editPrice", price);
                    cmd.Parameters.AddWithValue("@editSummary", summary);
                    cmd.Parameters.AddWithValue("@editImage", bImg);
                    cmd.Parameters.AddWithValue("@editCategory", category);

                    con.Open();
                    int i = cmd.ExecuteNonQuery(); // select을 제외한 나머지는 ExecuteNonQuery 사용한다.
                    if (i == 1)
                    {
                        txtReset();
                        listUpdate();
                        gvBookViewSettings();
                        MessageBox.Show("정상적으로 수정 되었습니다.");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("수정 실패하였습니다.");
                        return;
                    }
                }
            }
        }

        private void btnXml_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmNaver_Click(object sender, EventArgs e)
        {
            string query = txtSearchNaver.Text; // 검색할 문자열
            string url = "https://openapi.naver.com/v1/search/book.xml?query=" + query; // 결과가 JSON 포맷
            // string url = "https://openapi.naver.com/v1/search/blog.xml?query=" + query;  // 결과가 XML 포맷
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Headers.Add("X-Naver-Client-Id", "Yzf9K4gepuEnsT1wzSvE"); // 클라이언트 아이디
            request.Headers.Add("X-Naver-Client-Secret", "xCyGt9b1vr");       // 클라이언트 시크릿
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string status = response.StatusCode.ToString();
            if (status == "OK")
            {
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                string text = reader.ReadToEnd();
                txtResult.Text += text;
            }
            else
            {
                Console.WriteLine("Error 발생=" + status);
            }
        }
    }
}
