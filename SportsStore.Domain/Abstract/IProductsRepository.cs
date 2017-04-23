﻿using System;
using System.Collections.Generic;
using System.Linq;
using SportsStore.Domain.Entities;

namespace SportsStore.Domain.Abstract {
	public interface IProductsRepository {

		IQueryable<Product> Products { get; }
		
	}
}
