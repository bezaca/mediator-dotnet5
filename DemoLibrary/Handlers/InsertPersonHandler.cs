using System.Threading;
using System.Threading.Tasks;
using DemoLibrary.Commands;
using DemoLibrary.DataAccess;
using DemoLibrary.Models;
using MediatR;

namespace DemoLibrary.Handlers
{
	public class InsertPersonHandler : IRequestHandler<InsertPersonCommand, PersonModel>
	{
		private readonly IDataAccess _data;

		public InsertPersonHandler(IDataAccess data)
		{
			this._data = data;
		}
		public Task<PersonModel> Handle(InsertPersonCommand request, CancellationToken cancellationToken)
		{
			return Task.FromResult(_data.InsertPerson(request.FirstName, request.LastName));
		}
	}
}