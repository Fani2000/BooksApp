<template>
  <nav>
    <router-link to="/">Home</router-link> |
    <router-link to="/books">My Books</router-link>
  </nav>
  <router-view/>
</template>

<script setup lang="ts">
import { provide } from 'vue';
import BookService from './Services/book.service';

provide("booksService", new BookService())
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
}

nav {
  padding: 30px;
}

nav a {
  font-weight: bold;
  color: #2c3e50;
}

nav a.router-link-exact-active {
  color: #42b983;
}
</style>
