using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace CadastroClientes.model
{
    public class Clientes
    {
        public List<Cliente> clientes = new List<Cliente>();
        static XmlSerializer serializer = new XmlSerializer(typeof(Cliente));
        public static void SalvarCliente(Cliente cliente)
        {
            Clientes clientes = ObterClientes();
            clientes.clientes.Add(cliente);
            SalvarClientes(clientes);
        }
        public static Clientes ObterClientes()
        {
            StreamReader file = ObterStreamReader();
            try
            {
                XmlSerializer reader = new XmlSerializer(typeof(Clientes));
                Clientes clientes = (Clientes)reader.Deserialize(file);
                return clientes;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return new Clientes();
            }
            finally
            {
                file.Close();
            }
        }
        public static Cliente BuscaClienteCpf(string cpf)
        {
            return null;
        }
        public static void RemoverCliente(string cpf)
        {
            Clientes clientes = ObterClientes();
            clientes.clientes.RemoveAll(e => e.cpf == cpf);
            SalvarClientes(clientes);
        }
        private static void SalvarClientes(Clientes clientes)
        {
            FileStream fileStream = ObterFileStream();
            try
            {
                XmlSerializer writer = new XmlSerializer(typeof(Clientes));
                writer.Serialize(fileStream, clientes);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                fileStream.Close();
            }
        }
        private static StreamReader ObterStreamReader()
        {
            return new StreamReader(ObterFileStream());
        }
        private static FileStream ObterFileStream()
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//Clientes01.xml";
            return File.Create(path);
        }
    }
}
