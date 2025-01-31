﻿namespace JordiAragonZaragoza.ToDos.Presentation.WebApi.Contracts.V1.Projects.ToDoItems.Requests
{
    using System;
    using JordiAragonZaragoza.ToDos.Presentation.WebApi.Contracts.V1.Projects.Requests;

    public record class UpdateToDoItemDetailRequest(
        string Title,
        bool IsDone,
        string Description,
        PriorityRequest Priority,
        DateTime? ExpirationDateOnUtc);
}