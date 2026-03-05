import { PlusIcon } from "lucide-react";
import { useState } from "react";
import { useTodoContext } from "../../hooks/useTodoContext";
import { Button } from "../../ui/Button/Button";
import { Input } from "../../ui/Input/Input";
import s from "./styles.module.css";

export const CreateTodoBar = () => {
  const [inputValue, setInputValue] = useState("");
  const { addTodo } = useTodoContext();

  const handleAddTodo = () => {
    if (inputValue.trim() === "") return;

    addTodo(inputValue);

    setInputValue("");
  };

  const isDisabled = inputValue.trim() === "" || inputValue.length > 100;

  return (
    <>
      <div className={s.createTodoBar}>
        <Input
          value={inputValue}
          onChange={(e) => setInputValue(e.target.value)}
          className={s.input}
          placeholder="Додати завдання"
        />
        <Button
          className={s.addButton}
          onClick={handleAddTodo}
          disabled={isDisabled}
        >
          <PlusIcon />
          Додати
        </Button>
      </div>
    </>
  );
};
