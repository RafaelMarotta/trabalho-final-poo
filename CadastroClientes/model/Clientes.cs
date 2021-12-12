using CadastroClientes.exceptions;
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
        public static void SalvarCliente(Cliente cliente, bool edicao)
        {
            Clientes clientes = ObterClientes();
            Cliente clienteCpf = clientes.clientes.Find(e => e.cpf == cliente.cpf);
            if (edicao)
            {
                clientes.clientes.Remove(clienteCpf);
            }
            else
            {
                if (clienteCpf != null)
                {
                    throw new ClienteInvalidoException("Já existe um cliente com esse CPF cadastrado!");
                }
            }
            
            clientes.clientes.Add(cliente);
            SalvarClientes(clientes);
        }
        public static Clientes ObterClientes()
        {
            try
            {
                XmlSerializer reader = new XmlSerializer(typeof(Clientes));
                using (StringReader sr = new StringReader(File.ReadAllText(ObterPath())))
                {
                    return (Clientes)reader.Deserialize(sr);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return new Clientes();
            }
        }
        public static Cliente ObterClienteCpf(string cpf)
        {
            return ObterClientes().clientes.Find(e => e.cpf == cpf);
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

        private static FileStream ObterFileStream()
        {
            var path = ObterPath();
            return File.Create(path);
        }
        private static string ObterPath()
        {
            return Directory.GetCurrentDirectory() + @"\clientes.xml";
        }
    }
}
