import IBook from "@/Models/book.model";

export interface IBookService {
 getAllBooks() : Promise<IBook[]>;
}