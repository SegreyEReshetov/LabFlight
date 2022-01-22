using AutoMapper;
using Business.MyEnties;
using Business.Interop;
using Business.MyRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.MyService
{
    public class TicketService : ITicketService
    {
        private readonly ITicketRepository _ticketRepository;
        private readonly IMapper _mapper;
        public TicketService(ITicketRepository ticketRepository, IMapper mapper)
        {
            _ticketRepository = ticketRepository;
            _mapper = mapper;
        }

        public TicketDto CreateOrUpdate(TicketDto Ticket)
        {
            var entity = _mapper.Map<Ticket>(Ticket);
            _ticketRepository.CreateOrUpdate(entity);
            return _mapper.Map<TicketDto>(entity);
        }
        public TicketDto Create(TicketDto Ticket)
        {
            var entity = _mapper.Map<Ticket>(Ticket);
            _ticketRepository.Create(entity);
            return _mapper.Map<TicketDto>(entity);
        }
        public IEnumerable<TicketDto> GetAll()
        {
            var Tickets = _ticketRepository.Query();
            return _mapper.Map<IEnumerable<Ticket>, IEnumerable<TicketDto>>(Tickets);
        }

        public TicketDto GetById(int id)
        {
            var entity = _ticketRepository.Read(id);
            return _mapper.Map<TicketDto>(entity);
        }

        public TicketDto Update(TicketDto Ticket)
        {
            var entity = _mapper.Map<Ticket>(Ticket);
            _ticketRepository.Update(entity);
            return _mapper.Map<TicketDto>(entity);
        }

        public void Delete(int id)
        {
            var entity = _ticketRepository.Read(id);
            _ticketRepository.Delete(entity);
        }
    }
}
