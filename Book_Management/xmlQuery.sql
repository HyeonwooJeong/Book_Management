--xml root 포함
--select * from Books for XML raw('Book'), ELEMENTS, ROOT('Books'), binary base64

--xml root 미포함
--select * from Books for XML raw('Book'), ELEMENTS, binary base64