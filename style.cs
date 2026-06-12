*{
  box-sizing: border-box;
}

:root {
  --bg: #08122A;
  --bg-2: #0b1835;
  --panel: #0d1b38;
  --panel-2: #102246;
  --border: #1c2f59;
  --text: #e6e8ee;
  --muted: #93a4c6;
  --blue: #0b5fff;
  --blue-hover: #2a74ff;
  --red: #d63b43;
  --shadow: 0 12px 40px rgba(0, 0, 0, 0.35);
}

html {
  scroll-behavior: smooth;
}

body {
  margin: 0;
  font-family: "Inter", sans-serif;
  background:
    radial-gradient(circle at top right, rgba(11, 95, 255, 0.14), transparent 25%),
    linear-gradient(180deg, #071125 0%, #08122A 100%);
  color: var(--text);
}

button {
  font-family: inherit;
}

.container {
  width: min(1180px, calc(100% - 32px));
  margin: 0 auto;
}

.utility-bar {
  border-bottom: 1px solid rgba(255,255,255,0.06);
  background: rgba(3, 8, 20, 0.7);
  font-size: 12px;
  color: var(--muted);
}

.utility-inner {
  display: flex;
  justify-content: space-between;
  align-items: center;
  min-height: 34px;
}

.dot {
  margin: 0 8px;
}

.site-header {
  position: sticky;
  top: 0;
  z-index: 20;
  backdrop-filter: blur(10px);
  background: rgba(8, 18, 42, 0.92);
  border-bottom: 1px solid rgba(255,255,255,0.06);
}

.nav {
  display: flex;
  justify-content: space-between;
  align-items: center;
  min-height: 72px;
}

.logo {
  font-size: 28px;
  font-weight: 900;
  letter-spacing: 0.08em;
  color: white;
}

.logo span {
  color: var(--blue);
}

.nav-links {
  display: flex;
  gap: 10px;
  flex-wrap: wrap;
}

.nav-link {
  background: transparent;
  border: 0;
  color: var(--muted);
  font-size: 14px;
  font-weight: 700;
  padding: 10px 14px;
  border-radius: 10px;
  cursor: pointer;
  transition: 0.2s ease;
}

.nav-link:hover,
.nav-link.active {
  color: white;
  background: rgba(255,255,255,0.05);
}

.ticker {
  overflow: hidden;
  border-bottom: 1px solid rgba(255,255,255,0.06);
  border-top: 1px solid rgba(255,255,255,0.04);
  background: rgba(255,255,255,0.02);
  white-space: nowrap;
}

.ticker-track {
  display: inline-block;
  padding: 12px 0;
  animation: ticker 24s linear infinite;
  color: var(--muted);
  font-size: 13px;
}

.ticker-track span {
  margin-right: 48px;
}

.live {
  color: var(--red);
}

@keyframes ticker {
  from { transform: translateX(100%); }
  to { transform: translateX(-100%); }
}

.page {
  display: none;
  padding: 42px 0 56px;
}

.page.active {
  display: block;
}

.hero-grid {
  display: grid;
  grid-template-columns: 1.25fr 0.75fr;
  gap: 24px;
  align-items: stretch;
}

.hero-copy,
.hero-card,
.metric-card,
.event-card,
.step-card,
.side-card,
.table-card,
.player-card,
.account-card,
.filter-box {
  background: linear-gradient(180deg, rgba(255,255,255,0.03), rgba(255,255,255,0.015));
  border: 1px solid var(--border);
  box-shadow: var(--shadow);
}

.hero-copy,
.hero-card,
.table-card,
.account-card,
.side-card {
  border-radius: 18px;
}

.hero-copy {
  padding: 42px;
}

.eyebrow {
  color: var(--blue);
  text-transform: uppercase;
  letter-spacing: 0.14em;
  font-size: 12px;
  font-weight: 800;
  margin-bottom: 12px;
}

.hero-copy h1 {
  font-size: clamp(40px, 6vw, 68px);
  line-height: 0.95;
  margin: 0 0 18px;
  letter-spacing: -0.04em;
}

.hero-text {
  font-size: 18px;
  color: var(--muted);
  line-height: 1.6;
  max-width: 620px;
}

.hero-actions {
  display: flex;
  gap: 12px;
  margin-top: 28px;
  flex-wrap: wrap;
}

.hero-card {
  padding: 28px;
  position: relative;
  overflow: hidden;
}

.hero-card::before {
  content: "";
  position: absolute;
  inset: 0;
  background:
    radial-gradient(circle at top right, rgba(11,95,255,0.22), transparent 28%),
    linear-gradient(135deg, transparent 0%, rgba(255,255,255,0.02) 100%);
  pointer-events: none;
}

.hero-card-top {
  position: relative;
  display: flex;
  gap: 8px;
  margin-bottom: 18px;
}

.pill,
.tag {
  display: inline-flex;
  align-items: center;
  border-radius: 999px;
  padding: 6px 10px;
  font-size: 11px;
  font-weight: 800;
  letter-spacing: 0.04em;
  text-transform: uppercase;
}

.pill {
  background: rgba(255,255,255,0.06);
  color: var(--text);
  border: 1px solid rgba(255,255,255,0.08);
}

.live-pill {
  background: rgba(214, 59, 67, 0.14);
  color: #ff8d92;
  border-color: rgba(214, 59, 67, 0.28);
}

.hero-card h3 {
  position: relative;
  margin: 0 0 8px;
  font-size: 28px;
}

.muted {
  color: var(--muted);
}

.small-text {
  color: var(--muted);
  font-size: 13px;
  margin-top: 8px;
}

.progress {
  width: 100%;
  height: 8px;
  border-radius: 999px;
  background: rgba(255,255,255,0.06);
  overflow: hidden;
  margin-top: 14px;
}

.progress-fill {
  height: 100%;
  border-radius: 999px;
  background: linear-gradient(90deg, var(--blue), #4b8cff);
}

.btn {
  border: 0;
  border-radius: 12px;
  padding: 14px 18px;
  font-size: 14px;
  font-weight: 800;
  cursor: pointer;
  transition: 0.2s ease;
}

.btn-primary {
  background: linear-gradient(180deg, #1d6bff 0%, var(--blue) 100%);
  color: white;
}

.btn-primary:hover {
  background: linear-gradient(180deg, #327bff 0%, var(--blue-hover) 100%);
  transform: translateY(-1px);
}

.btn-secondary {
  background: transparent;
  color: white;
  border: 1px solid var(--border);
}

.btn-secondary:hover {
  background: rgba(255,255,255,0.04);
}

.small-btn {
  padding: 10px 14px;
  font-size: 13px;
}

.metrics {
  margin-top: 24px;
  display: grid;
  grid-template-columns: repeat(3, 1fr);
  gap: 18px;
}

.metric-card {
  border-radius: 16px;
  padding: 22px;
}

.metric-card h3 {
  font-size: 34px;
  margin: 0;
}

.metric-card p {
  margin: 6px 0 0;
  color: var(--muted);
  font-size: 14px;
}

.section-block {
  margin-top: 56px;
}

.section-header {
  margin-bottom: 22px;
}

.section-header h2,
.page-title {
  margin: 0;
  font-size: clamp(28px, 4vw, 42px);
  letter-spacing: -0.03em;
}

.page-subtitle {
  color: var(--muted);
  margin-top: 10px;
  font-size: 16px;
}

.card-grid {
  display: grid;
  gap: 18px;
}

.card-grid.three-col,
.card-grid {
  grid-template-columns: repeat(3, 1fr);
}

.card-grid.two-col {
  grid-template-columns: repeat(2, 1fr);
}

.event-card,
.step-card,
.player-card {
  border-radius: 16px;
  padding: 20px;
}

.card-tags {
  display: flex;
  gap: 8px;
  margin-bottom: 14px;
  flex-wrap: wrap;
}

.tag {
  background: rgba(255,255,255,0.05);
  color: var(--muted);
  border: 1px solid rgba(255,255,255,0.08);
}

.tag.blue {
  background: rgba(11,95,255,0.14);
  color: #9ec0ff;
  border-color: rgba(11,95,255,0.25);
}

.event-card h3,
.step-card h3,
.player-card h3,
.account-card h3,
.side-card h3 {
  margin: 0 0 8px;
}

.price {
  font-size: 18px;
  font-weight: 800;
  margin: 12px 0 0;
}

.card-actions {
  display: flex;
  align-items: center;
  justify-content: space-between;
  gap: 12px;
  margin-top: 18px;
}

.text-link {
  background: transparent;
  border: 0;
  color: var(--muted);
  font-weight: 700;
  cursor: pointer;
}

.text-link:hover {
  color: white;
}

.steps-grid {
  display: grid;
  grid-template-columns: repeat(4, 1fr);
  gap: 18px;
}

.step-number {
  display: inline-block;
  color: var(--blue);
  font-size: 12px;
  font-weight: 900;
  letter-spacing: 0.1em;
  margin-bottom: 12px;
}

.page-top {
  margin-bottom: 24px;
}

.filter-row {
  display: flex;
  gap: 14px;
  flex-wrap: wrap;
  margin-bottom: 22px;
}

.filter-box {
  border-radius: 12px;
  padding: 14px 16px;
  color: var(--muted);
  font-weight: 700;
}

.two-col-layout {
  display: grid;
  grid-template-columns: 1.35fr 0.65fr;
  gap: 20px;
}

.side-col {
  display: grid;
  gap: 18px;
}

.side-card {
  padding: 20px;
}

.side-card ul,
.side-card ol {
  margin: 12px 0 0 18px;
  color: var(--muted);
  line-height: 1.8;
}

.table-card {
  padding: 10px;
  overflow-x: auto;
}

table {
  width: 100%;
  border-collapse: collapse;
}

th,
td {
  padding: 16px 14px;
  text-align: left;
}

th {
  color: var(--muted);
  font-size: 12px;
  text-transform: uppercase;
  letter-spacing: 0.08em;
}

tbody tr {
  border-top: 1px solid rgba(255,255,255,0.06);
}

tbody tr:hover {
  background: rgba(255,255,255,0.025);
}

.player-card {
  text-align: left;
}

.avatar {
  width: 56px;
  height: 56px;
  border-radius: 50%;
  display: grid;
  place-items: center;
  font-weight: 900;
  background: linear-gradient(180deg, #145dff, #0b5fff);
  margin-bottom: 16px;
}

.player-stat {
  margin: 6px 0 0;
  color: var(--muted);
}

.account-grid {
  display: grid;
  grid-template-columns: repeat(2, 1fr);
  gap: 18px;
}

.account-card {
  padding: 22px;
}

.status-row {
  display: flex;
  justify-content: space-between;
  gap: 16px;
  padding: 14px 0;
  border-top: 1px solid rgba(255,255,255,0.06);
}

.status-row:first-of-type {
  border-top: 0;
}

.status {
  border-radius: 999px;
  padding: 6px 10px;
  font-size: 12px;
  font-weight: 800;
}

.status.active {
  background: rgba(23,201,100,0.16);
  color: #61e29a;
}

.status.pending {
  background: rgba(214,59,67,0.14);
  color: #ff9aa0;
}

.status.inactive {
  background: rgba(255,255,255,0.05);
  color: var(--muted);
}

.site-footer {
  margin-top: 40px;
  border-top: 1px solid rgba(255,255,255,0.06);
  background: rgba(0,0,0,0.18);
  padding: 28px 0 40px;
}

.footer-top {
  display: flex;
  justify-content: space-between;
  gap: 20px;
  flex-wrap: wrap;
}

.footer-links {
  display: flex;
  gap: 16px;
  flex-wrap: wrap;
}

.footer-links a {
  color: var(--muted);
  font-weight: 600;
  text-decoration: none;
}

.footer-links a:hover {
  color: white;
}

.footer-bottom {
  margin-top: 18px;
  color: var(--muted);
  font-size: 14px;
}

@media (max-width: 980px) {
  .hero-grid,
  .two-col-layout,
  .account-grid {
    grid-template-columns: 1fr;
  }

  .metrics,
  .card-grid,
  .card-grid.three-col,
  .card-grid.two-col,
  .steps-grid {
    grid-template-columns: 1fr 1fr;
  }
}

@media (max-width: 680px) {
  .utility-inner,
  .nav {
    flex-direction: column;
    align-items: flex-start;
    gap: 10px;
    padding: 12px 0;
  }

  .metrics,
  .card-grid,
  .card-grid.three-col,
  .card-grid.two-col,
  .steps-grid,
  .account-grid {
    grid-template-columns: 1fr;
  }

  .hero-copy {
    padding: 28px;
  }

  .hero-card {
    padding: 22px;
  }

  .container {
    width: min(1180px, calc(100% - 20px));
  }
}
`
