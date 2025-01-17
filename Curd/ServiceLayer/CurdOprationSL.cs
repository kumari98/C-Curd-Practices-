﻿using Curd.CommonLayer.Model;
using Curd.RepositryLayer;
using System.Threading.Tasks;

namespace Curd.ServiceLayer
{
    public class CurdOprationSL:ICurdOprationSL
    {
        public readonly ICurdOprationRL _curdOprationRL;

        public CurdOprationSL(ICurdOprationRL CurdOprationRL)
        {
            _curdOprationRL = CurdOprationRL;
        }
        public async Task<CreateReacordReasponce> CreateRecord(CreateRecordRequest request)
        {
            return await _curdOprationRL.CreateRecord(request);
        }
    }
}
 