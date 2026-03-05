import type { ComponentProps } from "react";
import s from "./button.module.css";

type Variants = "primary" | "neutral" | "success" | "danger";

interface Props extends ComponentProps<"button"> {
  className?: string;
  variant?: Variants;
  children?: React.ReactNode;
}

type ButtonVariants = Record<Variants, string>;

export const Button = ({
  className = "",
  children,
  variant = "primary",
  ...rest
}: Props) => {
  const variants: ButtonVariants = {
    primary: s.primary,
    neutral: s.neutral,
    success: s.success,
    danger: s.danger,
  };

  return (
    <button
      className={`${s.button} ${variants[variant]} ${className}`}
      {...rest}
    >
      {children}
    </button>
  );
};
