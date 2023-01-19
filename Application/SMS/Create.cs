using Domain;
using MediatR;
using Persistence;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.SMS
{
    public class Create
    {
        public class Command : IRequest
        {
            public Messageinfo Messageinfo { get; set; }
        }
        public class Handler : IRequestHandler<Command>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                request.Messageinfo.AddDate = DateTime.UtcNow;
                _context.Messageinfo.Add(request.Messageinfo);
                await _context.SaveChangesAsync();
                return Unit.Value;
            }
        }
    }
}
