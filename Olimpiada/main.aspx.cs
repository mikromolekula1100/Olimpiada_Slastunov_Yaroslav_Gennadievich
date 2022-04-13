using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Olimpiada
{
	public partial class main : System.Web.UI.Page
	{
		SqlConnection connection = new SqlConnection("Server=DESKTOP-4DPCLPJ\\SQLEXPRESS01;Database=Qz;Trusted_Connection=True;");

		private int Question_Number;
		private int n;

		

		protected void Page_Load(object sender, EventArgs e)
		{ 
			//Тут должна быть передача с заглавной страницы данных о количестве вопросов в тесте и создание массива
			//для события следуюещего вопроса
			Question_Number = Convert.ToInt32(Request.QueryString["QuestionNumber"]);

			connection.Open();
			SqlCommand comm = new SqlCommand("SELECT count(*) FROM Question", connection);
			n = Convert.ToInt32(comm);

			int[] arr = new int[n];

			arr = create_array(Question_Number, n);

			load_questions_answers(arr);
		}

		//Создание массива с рандомными вопросами(не уникальными)
		public int[] create_array(int QuestionNumber, int n)
		{
			Random rand = new Random();
			int[] array = new int[Question_Number];
			for (int i = 0; i < Question_Number; i++)
			{
				array[i] = rand.Next(0, n);
			}
			return array;
		}



		public void load_questions_answers(int[] array)
		{
			connection.Open();
			//Выборка вопроса по id, который динамически бы изменялся в лейбле при событии след. вопроса
			for (int i = 0; i < array.Length; i++)
			{
				SqlCommand getQuestion = new SqlCommand("SELECT Title FROM Questions WHERE id = " + array[i], connection);
				SqlDataReader questionReader = getQuestion.ExecuteReader();

				while (questionReader.Read())
				{
					Label1.Text = questionReader[0].ToString();
				}
				questionReader.Close();
			}

			//Выборка ответов на вопрос по id вопроса, которые динамически изменялись в тексте кнопок при событии след. вопроса
			for (int i = 0; i < array.Length; i++)
			{
				SqlCommand getQuestion = new SqlCommand("SELECT Title FROM Answers WHERE QuestionId = " + array[i], connection);
				SqlDataReader answerReader = getQuestion.ExecuteReader();

				while (answerReader.Read())
				{
					Button1.Text = answerReader[0].ToString();
					Button2.Text = answerReader[0].ToString();
					Button3.Text = answerReader[0].ToString();
					Button4.Text = answerReader[0].ToString();
				}
				answerReader.Close();
			}
			connection.Close();
		}

		protected void Button5_Click(object sender, EventArgs e)
		{
			
		}
	}
}