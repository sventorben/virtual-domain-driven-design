namespace VDDD.Types


type Page =
  | Landingpage of string
  | Sessions
  | Code_of_conduct
  | Books
  | Communities
  | Podcasts

type Link = {
  url: string
  label: string
}

type Sessiondetails = {
  title: string
  date: string
  time: string
  img: string option
  video: string option
  embedded: string option
  podcast: string option
  description: string
  links: Link list
}

type Session =
  | Past_session of Sessiondetails
  | Upcoming_session of Sessiondetails

type Book = {
  title: string
  author: string
  img: string
  tags: string list
}

type Community = {
  name: string
  country: string
  city: string option
  url: string
  img: string
}

type Model = {
  menu_open: bool
  page: Page
  searchterm: string
  sessions: Session list
  books: Book list
  communities: Community list
}

type Msg = 
  | Toggle_menu
  | GoTo of Page
  | OnLogError of exn
  | Clicked_Anywhere
  
