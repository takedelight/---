import { createContext } from "react";
import type { Todo } from "../types/todo.type";

interface TodoContext {
  todos: Todo[];
  deleteTodo: (id: string) => void;
  toggleTodo: (id: string) => void;
  addTodo: (title: string) => void;
}

export const TodoContext = createContext<TodoContext | null>(null);
