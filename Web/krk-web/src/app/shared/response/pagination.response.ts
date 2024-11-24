export interface PaginationResponse<T> {
  data: T[],
  pageNumber: number,
  pageSize: number,
  totalPages: number,
}

export function emptyPaginationResponse<T>(pageNumber: number, pageSize: number): PaginationResponse<T> {
  return {
    data: [],
    pageNumber: pageNumber,
    pageSize: pageSize,
    totalPages: 1
  }
}
