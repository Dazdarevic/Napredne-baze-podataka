﻿using MediatR;
using Napredne_baze_podataka_API.DTOs;

namespace Napredne_baze_podataka_API.Queries.Admin
{
    public class GetAllReceptionistsQuery : IRequest<IEnumerable<ReceptionistDto>>
    {
    }
}
