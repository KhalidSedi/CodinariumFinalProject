using Business.Abstract;
using Business.BaseMessages;
using Core.Results.Abstract;
using Core.Results.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete.Dtos;
using Entities.Concrete.TableModels;
using FluentValidation;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        private readonly IValidator<Product> _validator;
        public ProductManager(IProductDal productDal, IValidator<Product> validator)
        {
            _productDal = productDal;
            _validator = validator;
        }
        public IResult Add(Product entity)
        {
            _productDal.Add(entity);

            var validator = _validator.Validate(entity);

            string errorMessage = " ";

            foreach (var item in validator.Errors)
            {
                errorMessage = item.ErrorMessage;
            }

            if (!validator.IsValid)
            {
                return new ErrorResult(errorMessage);
            }

            return new SuccessResult(UIMessages.ADDED_MESSAGE);
        }
        public IResult Update(Product entity)
        {
            entity.LastUpdatedDate = DateTime.Now;

            _productDal.Update(entity);

            return new SuccessResult(UIMessages.UPDATED_MESSAGE);
        }
        public IResult Delete(int id)
        {
            var data = GetById(id).Data;

            data.Deleted = id;

            _productDal.Update(data);

            return new SuccessResult(UIMessages.DELETED_MESSAGE);
        }
        public IDataResult<List<ProductDto>> GetProductWithCategoryId()
        {
            return new SuccesDataResult<List<ProductDto>>(_productDal.GetProductWithCategories());
        }

        public IDataResult<Product> GetById(int id)
        {
            return new SuccesDataResult<Product>(_productDal.GetById(id));
        }
    }
}

