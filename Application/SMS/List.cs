using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;
using System.Diagnostics;

namespace Application.SMS
{
    public class List
    {
        public class Query : IRequest<List<Messageinfo>>
        {

        }

        public class Handler : IRequestHandler<Query, List<Messageinfo>>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }


            public async Task<List<Messageinfo>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Messageinfo.ToListAsync();
            }

            //public async Task<Activity> Queue()
            //{
            //    var queue = new Queue<Activity>();
            //}
        }
    }
}
