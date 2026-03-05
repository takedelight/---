import { CheckCircle2, Circle, Clock, Trash2 } from "lucide-react";
import { useTodoContext } from "../../hooks/useTodoContext";
import s from "./styles.module.css";

interface Props {
  title: string;
  isCompleted: boolean;
  createdAt: Date;
  id: string;
}

export const TodoCard = ({ title, isCompleted, createdAt, id }: Props) => {
  const { deleteTodo, todos, toggleTodo } = useTodoContext();

  const handleDelete = (e: React.MouseEvent) => {
    e.stopPropagation();
    deleteTodo(id);
  };

  console.log(todos);

  return (
    <li
      onClick={() => toggleTodo(id)}
      className={`${s.card} ${isCompleted ? s.completed : ""}`}
    >
      <div className={s.statusIcon}>
        {isCompleted ? (
          <CheckCircle2 size={24} className={s.checkIcon} />
        ) : (
          <Circle size={24} className={s.circleIcon} />
        )}
      </div>

      <div className={s.content}>
        <h3 className={s.title}>{title}</h3>
        <div className={s.info}>
          <Clock size={14} />
          <span>
            {createdAt.toLocaleDateString("uk-UA", {
              day: "numeric",
              year: "2-digit",
              month: "2-digit",
            })}
          </span>
        </div>
      </div>

      <button
        className={s.deleteBtn}
        onClick={handleDelete}
        title="Видалити завдання"
      >
        <Trash2 size={20} />
      </button>
    </li>
  );
};
