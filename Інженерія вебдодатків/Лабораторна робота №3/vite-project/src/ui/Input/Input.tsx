import type { ComponentProps } from "react";

import s from "./input.module.css";

interface Props extends ComponentProps<"input"> {
  className?: string;
}

export const Input = ({ className = "", ...props }: Props) => {
  return <input className={` ${s.input} ${className}`} {...props} />;
};
