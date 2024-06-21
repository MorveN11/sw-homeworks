using MediatR;
using University.Business.Wrappers;

namespace University.Business.Mediators;

public class GetByPage<T>: IRequest<Pagination<T>>
{
    public int PageNumber { get; set; }
    public int PageSize { get; set; }

    public GetByPage(int pageNumber, int pageSize)
    {
        PageNumber = pageNumber;
        PageSize = pageSize;
    }
}