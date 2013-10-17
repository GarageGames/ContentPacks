singleton TSShapeConstructor(PlayerAnim_Disposition_Crouch_BackDAE)
{
   baseShape = "./PlayerAnim_Disposition_Crouch_Back.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Disposition_Crouch_BackDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Crouch_Back", "430", "459");
}
