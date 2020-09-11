﻿using APIRESTFul.Domain.Models;
using APIRESTFul.Domain.Services.Comunication;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APIRESTFul.Domain.Services
{
	public interface ICategoryService
	{
		Task<IEnumerable<Category>> ListAsync();
		Task<CategoryResponse> SaveAsync(Category category);
		Task<CategoryResponse> UpdateAsync(int id, Category category);
		Task<CategoryResponse> DeleteAsync(int id);
	}

}
