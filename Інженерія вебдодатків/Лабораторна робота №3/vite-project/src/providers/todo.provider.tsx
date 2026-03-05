import { useCallback, useMemo, useState, type PropsWithChildren } from "react";
import { TodoContext } from "../context/todo.context";
import type { Todo } from "../types/todo.type";

export const TodoProvider = ({ children }: PropsWithChildren) => {
  const [todos, setTodos] = useState<Todo[]>([]);

  const deleteTodo = useCallback((id: string) => {
    setTodos((prev) => prev.filter((todo) => todo.id !== id));
  }, []);

  const toggleTodo = useCallback((id: string) => {
    setTodos((prev) =>
      prev.map((todo) =>
        todo.id === id ? { ...todo, isCompleted: !todo.isCompleted } : todo,
      ),
    );
  }, []);

  const addTodo = useCallback((title: string) => {
    const newTodo: Todo = {
      id: new Date().toISOString(),
      title,
      isCompleted: false,
      createdAt: new Date(),
    };

    setTodos((prev) => [...prev, newTodo]);
  }, []);

  const value = useMemo(
    () => ({
      todos,
      deleteTodo,
      toggleTodo,
      addTodo,
    }),
    [todos, deleteTodo, toggleTodo, addTodo],
  );

  return <TodoContext.Provider value={value}>{children}</TodoContext.Provider>;
};
