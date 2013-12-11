<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
	<xsl:template match="/">
		<html>
			<body>
				<h1 style="text-align: left; font-color: #87ceeb; font-family: gabriola;">Classic Textbooks</h1>
					<xsl:for-each select="Books/Book">
						<xsl:sort select="Title" />
						<div style="border: 1px #000000 solid; font: 14px consolas;">
							<ul>
								<li style="font-weight: bold;">
									<label>Title: </label>
									<label><xsl:value-of select="Title"/></label>
								</li>
								<li>
									<label>Cover: </label>
									<label><xsl:value-of select="@Cover"/></label>
								</li>
								<li>
									<label>ISBN: </label>
									<label><xsl:value-of select="ISBN"/></label>
								</li>
								<li>
									<xsl:for-each select="Author">
									<label>Author: </label>
										<label><xsl:value-of select="Name/First"/>&#160;</label>
										<label><xsl:value-of select="Name/Last"/>&#160;</label>
										<label>Office: <xsl:value-of select="Contact/@Office"/>&#160;</label>
										<label>Phone: <xsl:value-of select="Contact/Phone"/></label><br />										
									</xsl:for-each>								
								</li>
								<li>
									<label>Publisher: </label>
									<label><xsl:value-of select="Publisher"/></label>
								</li>
								<li>
									<label>Year: </label>
									<label><xsl:value-of select="Year"/></label>
								</li>
								<li>
									<label>Edition: </label>
									<label><xsl:value-of select="Year/@Edition"/></label>
								</li>
							</ul>
						</div>
					</xsl:for-each>
			</body>
		</html>
	</xsl:template>
</xsl:stylesheet>