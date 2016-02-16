using LoginBancoTeste.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LoginBancoTeste.DAL
{
    public class SampleData : DropCreateDatabaseIfModelChanges<BancoContext>
    {
        protected override void Seed(BancoContext context)
        {
            var clientes = new List<Cliente>
            {
                new Cliente 
                { 
                    Nome = "Bruce Wayne", 
                    Endereco = new Endereco {
                        Rua = "Roger Dogson Street",
                        Cep = "242891",
                        Cidade = "Gothan City",
                    }, 
                    Email = "wayne@gmail.com", 
                    Telefone = "(21)98755-2039", 
                    Celular ="(21)96543-6243", 
                    Contas = new List<Conta> 
                    {
                        new Conta 
                        {
                            Saldo = 5340000,
                            TipoDeConta = TipoDeConta.CORRENTE
                        },
                        new Conta 
                        {
                            Saldo = 1280000,
                            TipoDeConta = TipoDeConta.POUPANCA
                        }
                    },
                    Username = "111",
                    Password = "senha123",
                },
                new Cliente 
                { 
                    Nome = "Mulher Maravilha", 
                    Endereco = new Endereco {
                        Rua = "Tonwaer Island",
                        Cep = "90221",
                        Cidade = "Laruska",
                    }, 
                    Email = "wonder_woman@gmail.com", 
                    Telefone = "(11)89856-6524", 
                    Celular ="(11)85799-6152" , 
                    Contas = new List<Conta> 
                    {
                        new Conta 
                        {
                            Saldo = 8000,
                            TipoDeConta = TipoDeConta.CORRENTE
                        }
                    },
                    Username = "222",
                    Password = "senha123"
                },
                new Cliente 
                { 
                    Nome = "Clark Kent", 
                    Endereco = new Endereco {
                        Rua = "Park Avenue",
                        Cep = "14567",
                        Cidade = "New York",
                    },
                    Email = "superman@gmail.com", 
                    Telefone = "(34)10283-9128", 
                    Celular ="(22)98476-6532" , 
                    Contas = new List<Conta> 
                    {
                        new Conta 
                        {
                            Saldo = 16500,
                            TipoDeConta = TipoDeConta.CORRENTE
                        }
                    },
                    Username = "333",
                    Password = "senha123",
                },
                new Cliente 
                { 
                    Nome = "Barry Allan", 
                    Endereco = new Endereco {
                        Rua = "Rosalin Street",
                        Cep = "10056",
                        Cidade = "São Francisco",
                    },
                    Email = "the_flash@justiceleague.com", 
                    Telefone = "(21)98765-4377", 
                    Celular = "(32)97745-3427" , 
                    Contas = new List<Conta> 
                    {
                        new Conta 
                        {
                            Saldo = 65000,
                            TipoDeConta = TipoDeConta.CORRENTE
                        }
                    },   
                    Username = "444",
                    Password = "senha123",
                },
                new Cliente 
                { 
                    Nome = "Tony Stark", 
                    Endereco = new Endereco {
                        Rua = "Columbus Circle",
                        Cep = "10019",
                        Cidade = "New York",
                    }, 
                    Email = "ironman@avengers.com", 
                    Telefone = "(31)93847-6253", 
                    Celular = "(32)79564-9817" , 
                    Contas = new List<Conta> 
                    {
                        new Conta 
                        {
                            Saldo = 759000,
                            TipoDeConta = TipoDeConta.CORRENTE

                        },
                        new Conta 
                        {
                            Saldo = 92000,
                            TipoDeConta = TipoDeConta.POUPANCA
                        },
                        new Conta 
                        {
                            Saldo = 12000,
                            TipoDeConta = TipoDeConta.CORRENTE
                        }
                    },    
                    Username = "555",
                    Password = "senha123",
                },
                new Cliente 
                { 
                    Nome = "Peter Parker", 
                    Endereco = new Endereco {
                        Rua = "Fifth Avenue",
                        Cep = "10010",
                        Cidade = "New York",
                    }, 
                    Email = "spider_man@gmail.com", 
                    Telefone = "(31)9485-6732", 
                    Celular = "(32)87634-1982" , 
                    Contas = new List<Conta> 
                    {
                        new Conta 
                        {
                            Saldo = 900,
                            TipoDeConta = TipoDeConta.CORRENTE
                        }
                    },                    
                    Username = "666",
                    Password = "senha123",
                },                
                new Cliente 
                { 
                    Nome = "Natasha", 
                    Endereco = new Endereco {
                        Rua = "Patruska Avenue",
                        Cep = "240067",
                        Cidade = "Moscou",
                    }, 
                    Email = "viuva_negra@avengers.com", 
                    Telefone = "(31)9485-6732", 
                    Celular = "(32)87634-1982" , 
                    Contas = new List<Conta> 
                    {
                        new Conta 
                        {
                            Saldo = 25000,
                            TipoDeConta = TipoDeConta.CORRENTE
                        }
                    },           
                    Username = "777",
                    Password = "senha123",
                },                                
                new Cliente 
                { 
                    Nome = "Bruce Banner", 
                    Endereco = new Endereco {
                        Rua = "Franklin Roosevelt Street",
                        Cep = "10023",
                        Cidade = "Los Angeles",
                    },
                    Email = "hulk@avengers.com", 
                    Telefone = "(31)9485-6732", 
                    Celular = "(32)87634-1982" , 
                    Contas = new List<Conta> 
                    {
                        new Conta 
                        {
                            Saldo = 48900, 
                            TipoDeConta = TipoDeConta.CORRENTE
                        }
                    },     
                    Username = "888",
                    Password = "senha123",
                }
            };

            clientes.ForEach(c => context.Clientes.Add(c));
            context.SaveChanges();

            //var usuarios = new List<ContaDeUsuario> {
            //    new ContaDeUsuario 
            //    {
            //        Username = "joao@banco.br",
            //        Password = "senha123",
            //        TipoDeUsuario = TipoDeUsuario.FUNCIONARIO
            //    }                
            //};
            //usuarios.ForEach(f => context.Usuarios.Add(f));
            //context.SaveChanges();

            base.Seed(context);
        }
    }
}