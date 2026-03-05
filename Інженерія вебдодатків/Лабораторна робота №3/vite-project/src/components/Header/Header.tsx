import s from "./header.module.css";

export const Header = () => {
  return (
    <header className={s.header}>
      <nav className={`${s.nav} container`}>
        <a className={s.logo} href="/">
          Лабораторна робота №3
        </a>
      </nav>
    </header>
  );
};
