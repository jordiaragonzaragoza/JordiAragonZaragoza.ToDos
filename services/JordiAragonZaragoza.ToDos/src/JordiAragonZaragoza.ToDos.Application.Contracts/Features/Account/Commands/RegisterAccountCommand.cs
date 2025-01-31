﻿namespace JordiAragonZaragoza.ToDos.Application.Contracts.Features.Account.Commands
{
    using JordiAragon.SharedKernel.Application.Contracts.Interfaces;
    using JordiAragonZaragoza.ToDos.Application.Contracts.Features.Account.Queries;

    public record class RegisterAccountCommand(string Firstname, string Lastname, string Email, string Password) : ICommand<AuthenticationOutputDto>;
}