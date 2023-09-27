using ClassicRigorAPI.Data;
using ClassicRigorAPI.Dto;
using ClassicRigorAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClassicRigorAPI.Services;

public class ClientService
{
    private readonly ClientContext _context;

    public ClientService(ClientContext context)
    {
        _context = context;
    }

    public string CadastrarCliente(ClienteDto clienteDto)
    {
        try
        {

            var clienteComMesmoCpf = _context.Cliente.FirstOrDefault(c => c.Cpf == clienteDto.Cpf);
            var clienteComMesmoRg = _context.Cliente.FirstOrDefault(c => c.Rg == clienteDto.Rg);
            if (clienteComMesmoCpf != null || clienteComMesmoRg != null)
            {
                return "Cliente com mesmo CPF ou RG já cadastrado.";
            }
            var c = clienteDto;
            var end = new Endereco
            {
                Cep = c.Endereco.Cep,
                Bairro = c.Endereco.Bairro,
                Rua = c.Endereco.Rua,
                Numero = c.Endereco.Numero,
                Cidade = c.Endereco.Cidade,
                Complemento = c.Endereco.Complemento,
            };
            var cliente = new Clientes
            {
                Nome = c.Nome,
                Sobrenome = c.Sobrenome,
                Cpf = c.Cpf,
                Rg = c.Rg,
                DataNascimento = c.DtNasc,
                Endereco = end,
                Telefone = c.Telefone,
                isWpp = c.WhatsApp,
                Email = c.Email
            };
            _context.Cliente.Add(cliente);
            _context.SaveChanges();
            return "Cliente Cadastrado com sucesso!";
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            return ex.ToString();
        }
    }
}
