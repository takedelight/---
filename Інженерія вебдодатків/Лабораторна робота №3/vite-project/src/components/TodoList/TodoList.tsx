import { Inbox } from "lucide-react";
import { useTodoContext } from "../../hooks/useTodoContext";
import { TodoCard } from "../TodoCard/TodoCard";
import s from "./styles.module.css";

export const TodoList = () => {
  const { todos } = useTodoContext();

  return (
    <div className={s.todoListContainer}>
      {todos.length === 0 ? (
        <div className={s.emptyState}>
          <Inbox size={48} strokeWidth={1.5} className={s.emptyIcon} />
          <p className={s.emptyText}>Список завдань порожній</p>
        </div>
      ) : (
        <ul className={s.todoList}>
          {todos.map((todo) => (
            <TodoCard
              id={todo.id}
              key={todo.id}
              createdAt={todo.createdAt}
              isCompleted={todo.isCompleted}
              title={todo.title}
            />
          ))}
        </ul>
      )}
    </div>
  );
};
