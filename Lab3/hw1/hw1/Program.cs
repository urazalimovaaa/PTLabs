using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace hw1
{
	class Program
	{
		
		static void ser()
		{
			Student student = new Student("Assem", "Urazalimova" , 19 , "16BD02161" , "FIT");
			BinaryFormatter binary = new BinaryFormatter();
			FileStream file = new FileStream("Lab3.xml", FileMode.OpenOrCreate, FileAccess.Write);

			try
			{
				binary.Serialize(file, student);
			}
			catch 
			{
				Console.Write("Error");
			}
			finally
			{
				file.Close();
			}
		}

		static void deser()
		{
			BinaryFormatter binary = new BinaryFormatter();
			FileStream file = new FileStream("Lab3.xml", FileMode.OpenOrCreate, FileAccess.Read);
			Student student = new Student();
			try
			{
				student = binary.Deserialize(file) as Student;
			}
			catch
			{
				Console.Write("error");
			}
			finally
			{
				file.Close();
			}

			Console.Write(student);
		}


		static void Main(string[] args)
		{
            ser();
			deser();
		}
	}
}