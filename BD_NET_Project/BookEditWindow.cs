using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_NET_Project
{
    public partial class BookEditWindow : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataRow element;
        private DataTable book;

        public BookEditWindow(DataRowView row)
        {
            InitializeComponent();
            connection = new SqlConnection("Data Source=ASIA-HP;Initial Catalog=LIBRARY;Persist Security Info=True;User ID=sa;Password=praktyka");
            adapter = new SqlDataAdapter();
            Update_combobox(book = new DataTable("BOOKS"), comboBoxTitle, "select * from BOOKS", "TITLE", "PUBLICATION_YEAR");
            Update_combobox(new DataTable("AUTHORS"), comboBoxAuthor, "select * from AUTHORS", "FIRST_NAME", "LAST_NAME");
            Update_combobox(new DataTable("PUBLISHING_HOUSES"), comboBoxPublishing, "select * from PUBLISHING_HOUSES", "ID_PUBLISHING_HOUSE", "PUBLISHING_NAME");
            Update_combobox(new DataTable("SECTIONS"), comboBoxSection, "select * from SECTIONS", "ID_SECTION", "SECTION_NAME");

            comboBoxTitle.SelectedItem = comboBoxTitle.Items.Cast<ComboBoxItem>().Where(title => title.Hidden["ID_BOOK"].ToString().Equals(row["ID"].ToString())).Single();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string title = comboBoxTitle.Text;
            string idAuthor = ((ComboBoxItem)comboBoxAuthor.SelectedItem).Hidden["ID_AUTHOR"].ToString();
            string idPublishingHouse = ((ComboBoxItem)comboBoxPublishing.SelectedItem).Hidden["ID_PUBLISHING_HOUSE"].ToString();
            string publicationYear = textBoxDate.Text;
            string idSection = ((ComboBoxItem)comboBoxSection.SelectedItem).Hidden["ID_SECTION"].ToString();
            string bookDescription = textBoxDescriprion.Text;
            string cover = textBoxLocation.Text;
            string isbn = textBoxISBN.Text;
            SqlCommand command;
            try
            {
                if (cover.Length > 0)
                {
                    command = new SqlCommand("UPDATE BOOKS SET TITLE=@title, ID_AUTHOR=@idAuthor, ID_PUBLISHING_HOUSE=@idPublishingHouse, "
                                                   + "PUBLICATION_YEAR = @publicationYear, ID_SECTION = @idSection, BOOK_DESCRIPTION = @bookDescription, "
                                                   + "COVER = @cover, ISBN = @isbn WHERE ID_BOOK = @IdBook", connection);

                }else
                {
                    command = new SqlCommand("UPDATE BOOKS SET TITLE=@title, ID_AUTHOR=@idAuthor, ID_PUBLISHING_HOUSE=@idPublishingHouse, "
                                                   + "PUBLICATION_YEAR = @publicationYear, ID_SECTION = @idSection, BOOK_DESCRIPTION = @bookDescription, "
                                                   + "ISBN = @isbn WHERE ID_BOOK = @IdBook", connection);
                }

                adapter.UpdateCommand = command;
                adapter.UpdateCommand.Parameters.Add("@IdBook", SqlDbType.Int, 12, "ID_BOOK");
                adapter.UpdateCommand.Parameters.Add("@title", SqlDbType.VarChar, 50, "TITLE");
                adapter.UpdateCommand.Parameters.Add("@idAuthor", SqlDbType.Int, 12, "ID_AUTHOR");
                adapter.UpdateCommand.Parameters.Add("@idPublishingHouse", SqlDbType.Int, 12, "ID_PUBLISHING_HOUSE");
                adapter.UpdateCommand.Parameters.Add("@publicationYear", SqlDbType.Int, 12, "PUBLICATION_YEAR");
                adapter.UpdateCommand.Parameters.Add("@idSection", SqlDbType.Int, 12, "ID_SECTION");
                adapter.UpdateCommand.Parameters.Add("@bookDescription", SqlDbType.VarChar, 100, "BOOK_DESCRIPTION");
                adapter.UpdateCommand.Parameters.Add("@cover", SqlDbType.Image, 0, "COVER");
                adapter.UpdateCommand.Parameters.Add("@isbn", SqlDbType.VarChar, 20, "ISBN");

                DataRow item = ((ComboBoxItem)comboBoxTitle.SelectedItem).Hidden;
                item["TITLE"] = title;
                item["ID_AUTHOR"] = idAuthor;
                item["ID_PUBLISHING_HOUSE"] = idPublishingHouse;
                item["PUBLICATION_YEAR"] = publicationYear;
                item["ID_SECTION"] = idSection;
                item["BOOK_DESCRIPTION"] = bookDescription;
                if(cover.Length > 0)
                {
                    item["COVER"] = GetPhoto(cover);
                }
                
                item["ISBN"] = isbn;
                adapter.Update(book);

                MessageBox.Show("Zapisano.");
                this.textBoxDate.Clear();
                this.textBoxDescriprion.Clear();
                this.textBoxISBN.Clear();
                this.textBoxLocation.Clear();

                Update_combobox(book, comboBoxTitle, "select * from BOOKS", "TITLE", "PUBLICATION_YEAR");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();

            string title = comboBoxTitle.Text;
            string idAuthor = ((ComboBoxItem)comboBoxAuthor.SelectedItem).Hidden["ID_AUTHOR"].ToString();
            string idPublishingHouse = ((ComboBoxItem)comboBoxPublishing.SelectedItem).Hidden["ID_PUBLISHING_HOUSE"].ToString();
            string publicationYear = textBoxDate.Text;
            string idSection = ((ComboBoxItem)comboBoxSection.SelectedItem).Hidden["ID_SECTION"].ToString();
            string bookDescription = textBoxDescriprion.Text;
            string cover = textBoxLocation.Text;
            string isbn = textBoxISBN.Text;

            try
            {
                adapter.SelectCommand = new SqlCommand("SELECT * FROM BOOKS", connection);
                adapter.Fill(dataSet, "BOOKS");
                SqlCommand command;
                if (cover.Length > 0)
                {
                    command = new SqlCommand("INSERT INTO BOOKS(TITLE, ID_AUTHOR, ID_PUBLISHING_HOUSE, PUBLICATION_YEAR, ID_SECTION, BOOK_DESCRIPTION, ISBN, COVER) "
                                    + " SELECT '" + title + "'," + idAuthor.ToString() + "," + idPublishingHouse + "," + publicationYear + "," + idSection + ", '"
                                    + bookDescription.ToString() + "','" + isbn.ToString() + "',"
                                    + " BulkColumn FROM Openrowset (Bulk '" + cover + "', Single_Blob) as image;", connection);
                }else
                {
                    command = new SqlCommand("INSERT INTO BOOKS(TITLE, ID_AUTHOR, ID_PUBLISHING_HOUSE, PUBLICATION_YEAR, ID_SECTION, BOOK_DESCRIPTION, ISBN) "
                                    + " SELECT '" + title + "'," + idAuthor.ToString() + "," + idPublishingHouse + "," + publicationYear + "," + idSection + ", '"
                                    + bookDescription.ToString() + "','" + isbn.ToString() + "'", connection);
                }

                adapter.InsertCommand = command;
                adapter.SelectCommand = command;
                adapter.Fill(dataSet, "BOOKS");
                adapter.Update(dataSet, "BOOKS");

                adapter.Update(book);
                Update_combobox(book, comboBoxTitle, "select * from BOOKS", "TITLE", "PUBLICATION_YEAR");

                MessageBox.Show("Zapisano.");
                this.textBoxDate.Clear();
                this.textBoxDescriprion.Clear();
                this.textBoxISBN.Clear();
                this.textBoxLocation.Clear();
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        public void Update_combobox(DataTable transaction, ComboBox combo, String select, String field, String field2)
        {
            try
            {
                if (transaction.Rows.Count == 0)
                {
                    adapter.SelectCommand = new SqlCommand(select, connection);
                    adapter.Fill(transaction);
                }
                combo.Items.Clear();
                for (int i = 0; i < transaction.Rows.Count; ++i)
                {
                    ComboBoxItem item = new ComboBoxItem()
                    {
                        Text = transaction.Rows[i][field].ToString() + " " + transaction.Rows[i][field2].ToString(),
                        Hidden = transaction.Rows[i]
                    };
                    combo.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int idBook = int.Parse(((ComboBoxItem)comboBoxTitle.SelectedItem).Hidden["ID_BOOK"].ToString());
                SqlCommand command = new SqlCommand($"DELETE FROM BOOKS WHERE ID_BOOK={ idBook }", connection);
                adapter.UpdateCommand = command;
                DataRow item = ((ComboBoxItem)comboBoxTitle.SelectedItem).Hidden;
                item["ID_BOOK"] = idBook;
                adapter.Update(book);

                MessageBox.Show("Usunięto.");
                this.textBoxDate.Clear();
                this.textBoxDescriprion.Clear();
                this.textBoxISBN.Clear();
                this.textBoxLocation.Clear();

                Update_combobox(book, comboBoxTitle, "select * from BOOKS", "TITLE", "PUBLICATION_YEAR");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            element = ((ComboBoxItem)comboBoxTitle.SelectedItem).Hidden;

            this.textBoxDate.Text = element["PUBLICATION_YEAR"].ToString();
            this.textBoxDescriprion.Text = element["BOOK_DESCRIPTION"].ToString();
            this.textBoxISBN.Text = element["ISBN"].ToString();
            this.comboBoxAuthor.SelectedItem = comboBoxAuthor.Items.Cast<ComboBoxItem>().Where(x => x.Hidden["ID_AUTHOR"].ToString().Equals(element["ID_AUTHOR"].ToString())).Single();
            this.comboBoxPublishing.SelectedItem = comboBoxPublishing.Items.Cast<ComboBoxItem>().Where(x => x.Hidden["ID_PUBLISHING_HOUSE"].ToString().Equals(element["ID_PUBLISHING_HOUSE"].ToString())).Single();
            this.comboBoxSection.SelectedItem = comboBoxSection.Items.Cast<ComboBoxItem>().Where(x => x.Hidden["ID_SECTION"].ToString().Equals(element["ID_SECTION"].ToString())).Single();
        }

        public static byte[] GetPhoto(string filePath)
        {
            using (FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader reader = new BinaryReader(stream))
                {
                    return reader.ReadBytes((int)stream.Length);
                }
            }
        }
    }
}
