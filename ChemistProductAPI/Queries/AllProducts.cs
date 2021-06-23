using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using ChemistProductAPI.Model;

namespace ChemistProductAPI.Queries
{
    public class AllProducts : IRequest<IEnumerable<ProductDetails>> { }
}
