using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AltenChallengeApp.Core.Entities;
using AltenChallengeApp.Core.Interfaces;
using AltenChallengeApp.Infrastructure.Services.VehicleDetailsService;
using AltenChallengeApp.Infrastructure.Services.VehicleService.Dtos;
using AltenChallengeApp.Infrastructure.Specifications;
using AutoMapper;

namespace AltenChallengeApp.Infrastructure.Services.VehicleService
{
    public class VehilceService : IVehicleService
    {
        private readonly IRepository<Vehicle> _vehicleRepository;
        private readonly IMapper _mapper;
        private readonly IVehicleDetailsService _vdService;

        public VehilceService(IRepository<Vehicle> vehicleRepository, IMapper mapper, IVehicleDetailsService vdService)
        {
            _vehicleRepository = vehicleRepository;
            _mapper = mapper;
            _vdService = vdService;
        }

        public async Task<ListVehiclesOutput> GetAll(ListVehiclesInput input)
        {
            var specs = new VehicleFilterSpecification(input.CustomerId);
            var vehicles = _mapper.Map<List<GetVehicleOutput>>(_vehicleRepository.List(specs));

            var vehicleDetails = await _vdService.GetAll();
            var getVehicleDetailsOutputs = vehicleDetails.ToList();

            if (getVehicleDetailsOutputs.Any())
            {
                foreach (var vehicle in vehicles)
                {
                    if (getVehicleDetailsOutputs.Any(x => x.VehicleId == vehicle.Id))
                    {
                        vehicle.Status = true;
                    }
                }
            }
            return new ListVehiclesOutput { Vehicles = vehicles };
        }
    }
}
