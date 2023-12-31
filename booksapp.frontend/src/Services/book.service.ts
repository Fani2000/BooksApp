import IBook from "@/Models/book.model";
import { IBookService } from './IbookService'
import axios from "axios";

export default class BookService implements IBookService {
    async getAllBooks(): Promise<IBook[]> {
        const results = await axios.get(`${this.API_URL}/books/`)
        return results.data;
    }

    API_URL = process.env.VUE_APP_API_URL;

}