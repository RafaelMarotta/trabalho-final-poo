using CadastroClientes.exceptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace CadastroClientes.model
{
    public class Clientes
    {
        public List<Cliente> Itens = new List<Cliente>();
        public static void SalvarCliente(Cliente cliente, bool edicao)
        {
            Clientes clientes = ObterClientes();
            Cliente clienteCpf = clientes.Itens.Find(e => e.Cpf == cliente.Cpf);
            if (edicao)
            {
                clientes.Itens.Remove(clienteCpf);
            }
            else
            {
                if (clienteCpf != null)
                {
                    throw new ClienteInvalidoException("Já existe um cliente com esse CPF cadastrado!");
                }
            }
            
            clientes.Itens.Add(cliente);
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
            return ObterClientes().Itens.Find(e => e.Cpf == cpf);
        }
        public static void RemoverCliente(string cpf)
        {
            Clientes clientes = ObterClientes();
            clientes.Itens.RemoveAll(e => e.Cpf == cpf);
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
            return Directory.GetCurrentDirectory() + @"\Clientes.xml";
        }
    }
}
