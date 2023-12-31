import IBook from "@/Models/book.model";
import { IBookService } from "@/Services/IbookService";
import BookService from "@/Services/book.service";
import { defineComponent, inject, onMounted, ref } from "vue";

export default defineComponent({
    setup() {
        const books = ref<IBook[]>([])

        const bookService: IBookService | undefined = inject('booksService');

        onMounted(async () => {
            console.log(bookService)
            books.value = await bookService!.getAllBooks();
        })

        return { books }
    },
})