using FluentValidation;
using JRShop.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace JRShop.Dominio.Validacoes
{
    public class ValidacaoUsuario : AbstractValidator<Usuario>
    {
        
        public ValidacaoUsuario()
        {
            RuleFor(c => c.Nome).NotEmpty().WithMessage("O nome não pode ser vazio")
                                .MaximumLength(250);

            RuleFor(c => c.Email).NotEmpty().WithMessage("O email não pode ser vazio")
                                .MaximumLength(30).WithMessage("O email não pode ter mais de 30 caracteres")
                                 .MinimumLength(5).WithMessage("O email não pode ter menos de 5 caracteres");

            RuleFor(c => c.Senha).NotEmpty().WithMessage("A senha deve ser preenchida não pode ser vazia")
                                .MaximumLength(214)
                                 .MinimumLength(2).WithMessage("Formato da senha incorreta");

            //RuleFor(c => c.ConfirmPassword).Equal(c => c.Password).WithMessage("As senhas não conferem")
            //                    .MaximumLength(214)
            //                     .MinimumLength(2).WithMessage("Formato Password incorreto");

        }
    }
}
