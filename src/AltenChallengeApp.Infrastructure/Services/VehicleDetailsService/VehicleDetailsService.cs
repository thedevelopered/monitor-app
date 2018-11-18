using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AltenChallengeApp.AzureStorage.Entity;
using AltenChallengeApp.AzureStorage.Storage;
using AltenChallengeApp.Core.Dtos.VehicleDetails;
using AltenChallengeApp.Core.Services;
using AutoMapper;
using Microsoft.WindowsAzure.Storage.Table;

namespace AltenChallengeApp.Infrastructure.Services.VehicleDetailsService
{
    public class VehicleDetailsService : IVehicleDetailsService
    {
        private readonly IAzureTableStorage<VehicleDetails> _repository;
        private readonly IMapper _mapper;

        public VehicleDetailsService(IAzureTableStorage<VehicleDetails> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GetVehicleDetailsOutput>> GetAll()
        {
            var lowerlimit = DateTimeOffset.Now.AddMinutes(-1);

            var query = TableQuery.GenerateFilterConditionForDate("Timestamp", QueryComparisons.GreaterThanOrEqual, lowerlimit);

            var vehicleDetails = await _repository.GetList(query);
            return _mapper.Map<IEnumerable<GetVehicleDetailsOutput>>(vehicleDetails);
        }

        public async Task Insert(InsertVehicleDetailsInput input)
        {
            if (Guid.Empty == input.VehicleId)
                throw new ArgumentNullException("Empty vehicle id");
            await _repository.Insert(_mapper.Map<VehicleDetails>(input));
        }
    }
}
