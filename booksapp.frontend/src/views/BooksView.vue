<template>
    <div>
        <h1>My Books</h1>
        <template v-for="book in books" :key="book.id">
            <div>
                {{ book.title }} => {{ book.author }}
            </div>
        </template>
    </div>
</template>
<script lang="ts" src="./BooksView.ts"></script>