import React from 'react'
import { Grid,Image } from 'semantic-ui-react'
const styleLink = document.createElement("link"); styleLink.rel = "stylesheet"; styleLink.href = "https://cdn.jsdelivr.net/npm/semantic-ui/dist/semantic.min.css"; document.head.appendChild(styleLink);


export const CardMovie = (props) => {
    return (
        <Grid>
    <Grid.Column width={4}>
      <Image src={require(`${props.Url}`)} />
    </Grid.Column>
    <Grid.Column width={9}>
      <Image src='/images/wireframe/paragraph.png' />
    </Grid.Column>
    <Grid.Column width={3}>
      <Image src='/images/wireframe/media-paragraph.png' />
    </Grid.Column>
  </Grid>
    )
}
